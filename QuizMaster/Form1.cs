using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster
{
    public partial class Form1 : Form
    {
        int gameTime = 60;
        int currentTime = 0;
        int questionTime = 5;
        DataTable dataTable = null;
        int row = 0;
        int score = 0;
        bool hasSkipped = false;
        bool hasUsed5050 = false;
        bool isSpecialQuestion = false;
        int specialQuestionIndex = 0;
        int bonusPoints = 5;
        int currentQuestion = 0;

        Question question = null;
        List<Question> questionList = null;
        List<Question> currentQuestions = null;

        TabPage tabLogin;
        TabPage tabRegister;
        TabPage tabGame;
        TabPage tabGamemode;
        TabPage tabLeaderboard;
        TabPage tabAdministrator;
        Random random = new Random();
       
        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";

        public Form1()
        {
            InitializeComponent();
            //size for login /register 
            this.ClientSize = new Size(320, 372);

            // Remember the existing tabs
            tabLogin = tbControl.TabPages["tbpLogin"];
            tabRegister = tbControl.TabPages["tbpRegister"];
            tabGame = tbControl.TabPages["tbpGame"];
            tabGamemode = tbControl.TabPages["tbpChooseGamemode"];
            tabLeaderboard = tbControl.TabPages["tbpLeaderboard"];
            tabAdministrator = tbControl.TabPages["tbpAdministrator"];

            // Hide tabs that should only appear after login
            // tbControl.TabPages.Remove(tabGame);
            tbControl.TabPages.Remove(tabLeaderboard);
            tbControl.TabPages.Remove(tabAdministrator);
            tbControl.TabPages.Remove(tabGamemode);
            tbControl.TabPages.Remove(tabGame);

            // Start on the Register tab
            tbControl.SelectedTab = tabRegister;

            // Keep your existing timer and answer button setup
            tmrGame.Interval = 1000;
            gameTime = 60;
            lblTimer.Text = "Time: " + gameTime;
            btnTriangle.Click += CheckAnswer;
            btnCircle.Click += CheckAnswer;
            btnDiamond.Click += CheckAnswer;
            btnSquare.Click += CheckAnswer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           tbpAdministrator.Visible = false;
        }

        /// <summary>
        /// Logic Logic
        /// checking to see if there is an used that fits the playername and password
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string playername = tbxLogin.Text.Trim().ToLower();
            string password = tbxLoginPassword.Text.Trim();

            if (playername == "" || password == "")
            {
                MessageBox.Show("Username and Password Required!");
                return;
            }

            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "SELECT IsAdmin FROM login " +
                        "WHERE PlayerName = @PlayerName AND Password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlayerName", playername);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            bool isAdmin = Convert.ToBoolean(result);

                            // Show gamemodes and leaderboard tabs
                            if (!tbControl.TabPages.Contains(tabGamemode))
                                tbControl.TabPages.Add(tabGamemode);

                            if (!tbControl.TabPages.Contains(tabLeaderboard))
                                tbControl.TabPages.Add(tabLeaderboard);

                            // Show Administrator tab only for admins
                            if (isAdmin)
                            {
                                if (!tbControl.TabPages.Contains(tabAdministrator))
                                    tbControl.TabPages.Add(tabAdministrator);
                            }
                            else
                            {
                                tbControl.TabPages.Remove(tabAdministrator);
                            }


                            this.ClientSize = new Size(600, 350);
                            this.CenterToScreen();
                            // Open the gamemodes tab
                            tbControl.SelectedTab = tabGamemode;

                            MessageBox.Show("Logged in successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Register Logic
        /// Adding the Playername and password for the new user to the database 
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            tbControl.SelectedIndex = 1;
            string playername = tbxRegister.Text.Trim();
            string password = tbxRegisterPassword.Text.Trim();

            if (playername == "" || password == "")
            {
                MessageBox.Show("All fields must be filled in to proceed");
                return;
            }
            else
            {
                //perform registration logics
                try
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    using (conn)
                    {
                        conn.Open();
                        string query = "INSERT INTO login (PlayerName, Password, IsAdmin) " + "VALUES (@PlayerName, @Password, @IsAdmin)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PlayerName", playername.ToLower());
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@IsAdmin", cbxIsAdmin.Checked);

                        int status = cmd.ExecuteNonQuery();

                        if (status > 0)
                        {
                            MessageBox.Show("Account created succesfully!");
                            conn.Close();
                            tbControl.SelectedIndex = 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnGamemodeGames_Click_1(object sender, EventArgs e)
        {
            currentTime = gameTime;
            GetAllQuestions();
            GamemodeGames();
            StartQuiz(); ;
        }

        private void btnGamemodeStandard_Click(object sender, EventArgs e)
        {

            currentTime = gameTime;
            GetAllQuestions();
            GamemodeStandard();
            StartQuiz();
        }

        private void btnGamemodeBooks_Click(object sender, EventArgs e)
        {
            currentTime = gameTime;
            GetAllQuestions();
            GamemodeBooks();
            StartQuiz();
        }
        private void btnGameModeSpecial_Click(object sender, EventArgs e)
        {
            SpecialQuiz specialQuizForm = new SpecialQuiz(tbxLogin.Text.Trim());
            specialQuizForm.ShowDialog();
        }
        private void StartQuiz()
        {
            if (currentQuestions == null || currentQuestions.Count == 0)
            {
                MessageBox.Show("No Questions available!");
                return;
            }

            ShuffleList();

            currentQuestion = 0;
            score = 0;
            currentTime = gameTime;
            questionTime = 5;
            hasSkipped = false;
            btnSkipQuestion.Visible = true;

            DisplayQuestion();
            tmrGame.Start();
        }

        /// <summary>
        /// RANDOMISING LIST SO EACH QUIZ WILL BE UNIQUE
        /// </summary>
        private void ShuffleList()
        {
            for (int i = currentQuestions.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Question temp = currentQuestions[i];
                currentQuestions[i] = currentQuestions[j];
                currentQuestions[j] = temp;
            }
        }

        private void GamemodeGames()
        {
            currentQuestions = questionList.Where(q => q.GetCategory() == "Games").ToList();
        }

        private void GamemodeStandard()
        {
            currentQuestions = questionList.ToList();
        }

        private void GamemodeBooks()
        {
            currentQuestions = questionList.Where(q => q.GetCategory() == "Books").ToList();
        }

        private void GetAllQuestions()
        {
            questionList = new List<Question>();
            row = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                dataTable = new DataTable("questions");

                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM questions ORDER BY QuestionID", conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow rows in dataTable.Rows)
                {
                    question = new Question(
                        Convert.ToInt32(dataTable.Rows[row][0]),
                        dataTable.Rows[row][1].ToString(),
                        dataTable.Rows[row][2].ToString(),
                        dataTable.Rows[row][3].ToString(),
                        dataTable.Rows[row][4].ToString(),
                        dataTable.Rows[row][5].ToString(),
                        dataTable.Rows[row][6].ToString()
                    );

                    questionList.Add(question);
                    row++;
                }
            }
            else
            {
                MessageBox.Show("No items found");
            }
        }


        private void DisplayQuestion()
        {
            if (currentQuestions == null || currentQuestions.Count == 0)
            {
                MessageBox.Show("No Questions available!");
                return;
            }

            // Get the current question
            Question current = currentQuestions[currentQuestion];

            // Display question
            lblQuestion.Text = current.GetQuestion();

            // Collect all four answers
            List<string> answers = new List<string>
    {
        current.GetCorrectAnswer(),
        current.GetFalseAnswerOne(),
        current.GetFalseAnswerTwo(),
        current.GetFalseAnswerThree()
    };

            // Shuffle the answers
            for (int i = answers.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                string temp = answers[i];
                answers[i] = answers[j];
                answers[j] = temp;
            }

            btnTriangle.Text = answers[0];
            btnCircle.Text = answers[1];
            btnDiamond.Text = answers[2];
            btnSquare.Text = answers[3];

            btnTriangle.Enabled = true;
            btnCircle.Enabled = true;
            btnDiamond.Enabled = true;
            btnSquare.Enabled = true;

            questionTime = 5;

            lblTimer.Text = "Time: " + currentTime;
            lblQuestionTime.Text = "Question time: " + questionTime;

            lblTimer.ForeColor = Color.White;
            lblQuestionTime.ForeColor = Color.White;

            hasUsed5050 = false;
            btn5050.Enabled = true;

            btnSkipQuestion.Visible = true;
            btnSkipQuestion.Enabled = !hasSkipped;
        }


        private void CheckAnswer(object sender, EventArgs e)
        {
            tmrGame.Stop();
            Button clickedButton = sender as Button;

            //Get the correct answer for this question
            string correctAnswer = currentQuestions[currentQuestion].GetCorrectAnswer();

            //checked the clicked button
            if (clickedButton.Text == correctAnswer)
            {
                MessageBox.Show("Correct!");
                score++;
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }

            // Move to the next question
            currentQuestion++;

            // Check if there are more questions
            if (currentQuestion < currentQuestions.Count)
            {
                questionTime = 5;
                DisplayQuestion();
                tmrGame.Start();
            }
            else
            {
                tmrGame.Stop();
                MessageBox.Show("Quiz completed!");
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            currentTime--;
            questionTime--;
            lblTimer.Text = "Time:" + currentTime;

            if (currentTime <= 0)
            {
                tmrGame.Stop();
                SaveScore();
                MessageBox.Show("Time''s up");
                EndGame();
                return;
            }

            if (questionTime <= 0)
            {
                currentQuestion++;
                //check to see if there are still questions
                if (currentQuestion < currentQuestions.Count)
                {
                    questionTime = 5;
                    DisplayQuestion();
                }
                else
                {
                    tmrGame.Stop();
                    SaveScore();
                    EndGame();
                    MessageBox.Show("Quiz Completed!");
                }
            }
        }

        private void SaveScore()
        {
            string playerName = tbxLogin.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO score (PlayerName, Score, Date)" + "VALUES (@PlayerName, @SCore, @Date)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerName", playerName);
                    cmd.Parameters.AddWithValue("@Score", score);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadLeaderboard()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT PlayerName, Score, Date " +
                               "FROM score " +
                               "ORDER BY Score DESC";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvLeaderboard.DataSource = table;
                }
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbControl.SelectedTab == tabLogin ||
                tbControl.SelectedTab == tabRegister)
            {
                this.ClientSize = new Size(300, 350);
                this.CenterToScreen();
            }

            if (tbControl.SelectedTab == tabLeaderboard)
            {
                LoadLeaderboard();
            }

            if (tbControl.SelectedTab == tabAdministrator)
            {
                LoadQuestions();
                LoadUsers();
            }
        }

        private void btnSkipQuestion_Click(object sender, EventArgs e)
        {
            if (hasSkipped)
            {
                MessageBox.Show("You can only skip one question per match.");
                return;
            }

            hasSkipped = true;

            currentQuestion++;

            if (currentQuestion < currentQuestions.Count)
            {
                questionTime = 5;
                DisplayQuestion();
            }
            else
            {
                tmrGame.Stop();
                SaveScore();
                MessageBox.Show("Quiz Completed!");
            }

            btnSkipQuestion.Enabled = false;
        }

        private void LoadQuestions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Questions ORDER BY QuestionID";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvQuestions.DataSource = table;
                }
            }
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "SELECT PlayerID, PlayerName, IsAdmin FROM login";

                using (MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvUsers.DataSource = table;
                }
            }
        }

        private void EndGame()
        {
            // Stop the game timer
            tmrGame.Stop();

            // Reset the game timer and question timer
            currentTime = gameTime;
            questionTime = 5;

            // Reset the question index and score
            currentQuestion = 0;
            score = 0;
            hasSkipped = false;

            // Show the skip button again for the next game
            btnSkipQuestion.Visible = true;

            // Reset the timer label
            lblTimer.Text = "Time: " + gameTime;

            // Set the form size to the game mode selection size
            this.ClientSize = new Size(600, 300);
            this.CenterToScreen();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();

            addQuestionForm.ShowDialog();

            LoadQuestions();
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {

            if (dgvQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a question to edit.");
                return;
            }

            int questionId = Convert.ToInt32(
                dgvQuestions.SelectedRows[0].Cells["QuestionID"].Value
            );

            editQuestionForm form = new editQuestionForm(questionId);
            form.ShowDialog();

            LoadQuestions();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a question to delete.");
                return;
            }

            int questionId = Convert.ToInt32(
                dgvQuestions.SelectedRows[0].Cells["QuestionID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this question?",
                "Delete Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Questions WHERE QuestionID = @QuestionID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Question deleted successfully!");

            LoadQuestions();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUserForm form = new addUserForm();
            form.ShowDialog();

            LoadUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            int playerId = Convert.ToInt32(
                dgvUsers.SelectedRows[0].Cells["PlayerID"].Value
            );

            editUserForm form = new editUserForm(playerId);
            form.ShowDialog();

            LoadUsers();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int playerId = Convert.ToInt32(
                dgvUsers.SelectedRows[0].Cells["PlayerID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "DELETE FROM login WHERE PlayerID = @PlayerID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerID", playerId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User deleted successfully!");
            LoadUsers();
        }

        private void btn5050_Click(object sender, EventArgs e)
        {

            // Check if the joker has already been used
            if (hasUsed5050)
            {
                return;
            }

            // Get the correct answer
            string correctAnswer =
                currentQuestions[currentQuestion].GetCorrectAnswer();

            // Put all four answer buttons into a list
            List<Button> answerButtons = new List<Button>
            {
                btnTriangle,
                btnCircle,
                btnDiamond,
                btnSquare
            };

            // Find the button containing the correct answer
            Button correctButton = answerButtons.First(
                b => b.Text == correctAnswer
            );

            // Find all buttons containing incorrect answers
            List<Button> incorrectButtons = answerButtons
                .Where(b => b.Text != correctAnswer)
                .ToList();

            // Randomly choose one incorrect answer to keep
            int randomIndex = random.Next(incorrectButtons.Count);
            Button incorrectButton = incorrectButtons[randomIndex];

            // Disable the other two incorrect answers
            foreach (Button button in incorrectButtons)
            {
                if (button != incorrectButton)
                {
                    button.Enabled = false;
                }
            }

            // Mark the joker as used
            hasUsed5050 = true;
            btn5050.Enabled = false;
        }
    }
}