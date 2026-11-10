using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster
{
    public partial class Form1 : Form
    {
        int gameTime = 60;
        int currentTime = 0;
        int questionTime = 5;
        int row = 0;
        int score = 0;
        int specialQuestionIndex = 0;
        int bonusPoints = 5;
        int currentQuestion = 0;

        bool hasSkipped = false;
        bool hasUsedFiftyFifty = false;
        bool isSpecialQuestion = false;

        DataTable dataTable = null;
        Question question = null;
        List<Question> questionList = null;
        List<Question> currentQuestions = null;

        TabPage tabLogin;
        TabPage tabRegister;
        TabPage tabGamemodes;
        TabPage tabGame;
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
            tabGamemodes = tbControl.TabPages["tbpGamemodes"];
            tabGame = tbControl.TabPages["tbpGame"];
            tabLeaderboard = tbControl.TabPages["tbpLeaderboard"];
            tabAdministrator = tbControl.TabPages["tbpAdministrator"];

            // Hide tabs that should only appear after login
            tbControl.TabPages.Remove(tabGamemodes);
            tbControl.TabPages.Remove(tabGame);
            tbControl.TabPages.Remove(tabLeaderboard);
            tbControl.TabPages.Remove(tabAdministrator);

            // Start on the Login tab
            tbControl.SelectedTab = tabLogin;

            // Keep your existing timer and answer button setup
            tmrGame.Interval = 1000;
            gameTime = 60;
            btnAnswerOne.Click += CheckAnswer;
            btnAnswerTwo.Click += CheckAnswer;
            btnAnswerThree.Click += CheckAnswer;
            btnAnswerFour.Click += CheckAnswer;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbpAdministrator.Visible = false;
        }

        private void btnRegisterHere_Click(object sender, EventArgs e)
        { 
            //Changing to Login Tab
            tbControl.SelectedIndex = 1;            
        }

        private void btnLoginHere_Click(object sender, EventArgs e)
        {
            //Changing to Register Tab
            tbControl.SelectedIndex = 0;
        }

        /// <summary>
        /// Logic Logic
        /// checking to see if there is an used that fits the playername and password
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string playername = tbxLoginName.Text.Trim().ToLower();
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

                            // Show game and leaderboard tabs
                            if (!tbControl.TabPages.Contains(tabGamemodes))
                                tbControl.TabPages.Add(tabGamemodes);

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

                            

                            // Open the Game tab
                            tbControl.SelectedTab = tabGamemodes;

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
            string playername = tbxRegisterName.Text.Trim();
            string password = tbxRegisterPassword.Text.Trim();

            if(playername == "" || password == "")
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
                        string query = "INSERT INTO login (PlayerName, Password, IsAdmin) " +"VALUES (@PlayerName, @Password, @IsAdmin)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PlayerName", playername.ToLower());
                        cmd.Parameters.AddWithValue ("@Password", password);
                        cmd.Parameters.AddWithValue("@IsAdmin", cbxIsAdmin.Checked);

                        int status =cmd.ExecuteNonQuery();

                        if(status > 0)
                        {
                            MessageBox.Show("Account created succesfully!");
                            conn.Close();
                            tbControl.SelectedIndex = 1;
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void OpenGameTab()
        {
            if (!tbControl.TabPages.Contains(tabGame))
                tbControl.TabPages.Add(tabGame);

            tbControl.SelectedTab = tabGame;
        }

        private void btnGameModeOne_Click(object sender, EventArgs e)
        {
            OpenGameTab();
            pnlGame.Visible = true;

            currentTime = gameTime;
            GetAllQuestions();
            GameModeOne();
            StartQuiz(); 

            pnlGame.Visible = true;

            pnlGame.Dock = DockStyle.None;
            pnlGame.Size = new Size(600, 370);
            pnlGame.Location = new Point(10, 0);

            this.ClientSize = new Size(610, 380);
        }

        private void btnGameModeTwo_Click(object sender, EventArgs e)
        {
            OpenGameTab();
            pnlGame.Visible = true;

            currentTime = gameTime;
            GetAllQuestions();
            GameModeTwo();
            StartQuiz();

            pnlGame.Visible = true;

            pnlGame.Dock = DockStyle.None;
            pnlGame.Size = new Size(600, 370);
            pnlGame.Location = new Point(10, 0);

            this.ClientSize = new Size(610, 380);
        }

        private void btnGameModeThree_Click(object sender, EventArgs e)
        {
            OpenGameTab();
            pnlGame.Visible = true;

            currentTime = gameTime;
            GetAllQuestions();
            GameModeThree();
            StartQuiz();

            pnlGame.Visible = true;

            pnlGame.Dock = DockStyle.None;
            pnlGame.Size = new Size(600, 370);
            pnlGame.Location = new Point(10, 0);

            this.ClientSize = new Size(610, 380);
        }

        private void btnGameModeFour_Click(object sender, EventArgs e)
        {
            SpecialQuiz specialQuiz = new SpecialQuiz(tbxLoginName.Text.Trim());

            specialQuiz.ShowDialog();
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
            isSpecialQuestion = false;

            // Randomly choose a special question from the first 20 questions
            int questionsToChooseFrom = Math.Min(20, currentQuestions.Count);
            specialQuestionIndex = random.Next(questionsToChooseFrom);

            score = 0;
            currentTime = gameTime;
            questionTime = 5;
            hasSkipped = false;

            hasUsedFiftyFifty = false;
            btnFiftyFifty.Enabled = true;
            btnSkipQuestion.Visible = true;
            btnSkipQuestion.Enabled = true;

            // Reset both timer labels
            lblTimer.ForeColor = Color.White;
            lblQuestionTime.ForeColor = Color.White;

            lblTimer.Text = "Time: " + currentTime;
            lblQuestionTime.Text = "Question time: " + questionTime;

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

        private void GameModeOne()
        {
            currentQuestions = questionList.ToList();
        }

        private void GameModeTwo()
        {
            currentQuestions = questionList.Where(q => q.GetCategory() == "Games").ToList();
        }

        private void GameModeThree()
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

            //Restore answer Buttons
            btnAnswerOne.BackgroundImage = Properties.Resources.triangle;
            btnAnswerTwo.BackgroundImage = Properties.Resources.cube;
            btnAnswerThree.BackgroundImage = Properties.Resources.cubegreen;
            btnAnswerFour.BackgroundImage = Properties.Resources.circle;
            //get the current question
            Question q = currentQuestions[currentQuestion];

            // Check whether this is the randomly selected special question
            isSpecialQuestion = currentQuestion == specialQuestionIndex;

            if (isSpecialQuestion)
            {
                lblQuestion.Text = "*** SPECIAL QUESTION! ***\r\n" + q.GetQuestion();

                // Make the question stand out
                lblQuestion.BackColor = Color.Gold;
                lblQuestion.ForeColor = Color.DarkRed;
                lblQuestion.Font = new Font(lblQuestion.Font, FontStyle.Bold);

                // Play a sound when the special question appears
                SoundPlayer sp = new SoundPlayer(Properties.Resources.special_sound);
                sp.Play();
            }
            else
            {
                lblQuestion.Text = q.GetQuestion();

                // Restore the normal appearance
                lblQuestion.BackColor = Color.Transparent;
                lblQuestion.ForeColor = Color.White;
                lblQuestion.Font = new Font(lblQuestion.Font, FontStyle.Regular);
            }

            // Enable all answer buttons for the new question(for Fifty-Fifty logic)
            btnAnswerOne.Enabled = true;
            btnAnswerTwo.Enabled = true;
            btnAnswerThree.Enabled = true;
            btnAnswerFour.Enabled = true;

            //Put all 4 answers into a list
            List<string> answers = new List<string>
            {
                q.GetCorrectAnswer(),
                q.GetFalseAnswerOne(),
                q.GetFalseAnswerTwo(),
                q.GetFalseAnswerThree(),
            };

            //Shuffle all the answers 
            for(int i = answers.Count - 1; i >0;  i--)
            {
                int j = random.Next(i + 1);

                string temp = answers[i];
                answers[i] = answers[j];
                answers[j] = temp;
            }

            //Assign the shuffles answers to the buttons
            btnAnswerOne.Text = answers[0];
            btnAnswerTwo.Text = answers[1];
            btnAnswerThree.Text = answers[2];
            btnAnswerFour.Text = answers[3];
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            // Pause the game timer while showing messages
            tmrGame.Stop();

            Button clickedButton = sender as Button;

            string correctAnswer = currentQuestions[currentQuestion].GetCorrectAnswer();

            if (clickedButton.Text == correctAnswer)
            {
                score++;

                if (isSpecialQuestion)
                {
                    score += bonusPoints;

                    MessageBox.Show("Special question correct! You earned 5 bonus points!");
                }
                else
                {
                    MessageBox.Show("Correct!");
                }
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }

            currentQuestion++;

            if (currentQuestion < currentQuestions.Count)
            {
                questionTime = 5;
                lblQuestionTime.Text = "Question time: " + questionTime;

                DisplayQuestion();

                // Resume the timer after the message box is closed
                tmrGame.Start();
            }
            else
            {
                SaveScore();
                MessageBox.Show("Quiz completed!");
                EndGame();
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            currentTime--;
            questionTime--;

            // Update overall game timer
            lblTimer.Text = "Time: " + currentTime;

            if (currentTime < 10)
            {
                lblTimer.ForeColor = Color.Red;
            }
            else
            {
                lblTimer.ForeColor = Color.White;
            }

            // Update question timer
            lblQuestionTime.Text = "Question time: " + questionTime;

            // Check if overall game time has run out
            if (currentTime <= 0)
            {
                tmrGame.Stop();
                SaveScore();
                MessageBox.Show("Time's up!");
                EndGame();
                return;
            }

            // Check if question time has run out
            if (questionTime <= 0)
            {
                currentQuestion++;

                if (currentQuestion < currentQuestions.Count)
                {
                    questionTime = 5;
                    lblQuestionTime.Text = "Question time: " + questionTime;

                    DisplayQuestion();
                }
                else
                {
                    tmrGame.Stop();
                    SaveScore();
                    MessageBox.Show("Quiz completed!");
                    EndGame();
                }
            }
        }

        private void SaveScore()
        {
            string playerName = tbxLoginName.Text.Trim();

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
            if (tbControl.SelectedTab == tbpLeaderboard)
            {
                LoadLeaderboard();
            }
           
            if(tbControl.SelectedTab == tbpAdministrator)
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
                lblQuestionTime.Text = "Question time: " + questionTime;
                DisplayQuestion();
            }
            else
            {
                tmrGame.Stop();
                SaveScore();
                MessageBox.Show("Quiz completed!");
                EndGame();
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

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();

            addQuestionForm.ShowDialog();

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

        private void EndGame()
        {
            tmrGame.Stop();

            pnlGame.Visible = false;

            currentTime = gameTime;
            questionTime = 5;
            lblQuestionTime.Text = "Question time: 5";
            currentQuestion = 0;
            score = 0;
            hasSkipped = false;

            btnSkipQuestion.Visible = true;
            btnSkipQuestion.Enabled = true;

            lblTimer.Text = "Time: " + gameTime;

            this.ClientSize = new Size(350, 400);
            this.CenterToScreen();
        }

        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
            // Check if the joker has already been used
            if (hasUsedFiftyFifty)
            {
                return;
            }

            // Get the correct answer
            string correctAnswer =
                currentQuestions[currentQuestion].GetCorrectAnswer();

            // Put all four answer buttons into a list
            List<Button> answerButtons = new List<Button>
            {
                btnAnswerOne,
                btnAnswerTwo,
                btnAnswerThree,
                btnAnswerFour
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

                    button.BackgroundImage = null;
                    button.BackColor = Color.Gray;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.UseVisualStyleBackColor = false;
                }
            }

            // Mark the joker as used
            hasUsedFiftyFifty = true;
            btnFiftyFifty.Enabled = false;
        }
    }
}
