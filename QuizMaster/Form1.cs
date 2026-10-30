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

        Question question = null;
        List<Question> questionList = null;
        List<Question> currentQuestions = null;

        TabPage tabLogin;
        TabPage tabRegister;
        TabPage tabGame;
        TabPage tabLeaderboard;
        TabPage tabAdministrator;

        Random random = new Random();
        int currentQuestion = 0;

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
            tabLeaderboard = tbControl.TabPages["tbpLeaderboard"];
            tabAdministrator = tbControl.TabPages["tbpAdministrator"];

            // Hide tabs that should only appear after login
            tbControl.TabPages.Remove(tabGame);
            tbControl.TabPages.Remove(tabLeaderboard);
            tbControl.TabPages.Remove(tabAdministrator);

            // Start on the Login tab
            tbControl.SelectedTab = tabLogin;

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

                            // Show game and leaderboard tabs
                            if (!tbControl.TabPages.Contains(tabGame))
                                tbControl.TabPages.Add(tabGame);

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
                            tbControl.SelectedTab = tabGame;

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
            //get the current question
            Question q = currentQuestions[currentQuestion];

            //display teh question
            lblQuestion.Text = q.GetQuestion();

            //Put all 4 answers into a list
            List<string> answers = new List<string>
            {
                q.GetCorrectAnswer(),
                q.GetFalseAnswerOne(),
                q.GetFalseAnswerTwo(),
                q.GetFalseAnswerThree(),
            };

            //Shuffle all the answers 
            for (int i = answers.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                string temp = answers[i];
                answers[i] = answers[j];
                answers[j] = temp;
            }

            //Assign the shuffles answers to the buttons
            btnTriangle.Text = answers[0];
            btnDiamond.Text = answers[1];
            btnSquare.Text = answers[2];
            btnCircle.Text = answers[3];
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
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
            this.ClientSize = new Size(390, 383);
            this.CenterToScreen();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

       
    }
}