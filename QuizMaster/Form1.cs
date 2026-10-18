using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuizMaster
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        // Store the original positions of the PictureBoxes
        Point[] positions;
        TabPage tabLogin;
        TabPage tabRegister;
        TabPage tabGame;
        //TabPage tabLeaderboard;
        //TabPage tabAdministrator;
        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";
        int gameTime = 60;
        int currentTime = 0;
        int questionTime = 5;
        Question question = null;
        List<Question> questionList = null;
        List<Question> currentQuestions = null;

        public Form1()
        {
            InitializeComponent();

            // Remember the existing tabs
            tabLogin = tbControl.TabPages["tbLogin"];
            tabRegister = tbControl.TabPages["tbRegister"];
            tabGame = tbControl.TabPages["tbGame"];
            //tabLeaderboard = tbControl.TabPages["tbpLeaderboard"];
            //tabAdministrator = tbControl.TabPages["tbpAdministrator"];

            // Hide tabs that should only appear after login
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            Control clicked = (Control)sender;

            MessageBox.Show("You clicked: " + clicked.Name);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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

                            //if (!tbControl.TabPages.Contains(tabLeaderboard))
                              //  tbControl.TabPages.Add(tabLeaderboard);

                            // Show Administrator tab only for admins
                            if (isAdmin)
                            {
                               // if (!tbControl.TabPages.Contains(tabAdministrator))
                                 //   tbControl.TabPages.Add(tabAdministrator);
                            }
                            else
                            {
                               // tbControl.TabPages.Remove(tabAdministrator);
                            }



                            // Open the Game tab
                            tbControl.SelectedTab = tabGame;

                            //ShowGameModeSelection();

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

        private void btnGamemodeOne_Click(object sender, EventArgs e)
        {
            pnlChooseGameMode.Visible = false;
            pnlGame.Visible = true;

            currentTime = gameTime;
            GetAllQuestions();
            GameModeOne();
            StartQuiz(); ;

            pnlGame.Visible = true;
        }

        private void btnGamemodeTwo_Click(object sender, EventArgs e)
        {
            pnlChooseGameMode.Visible = false;
            pnlGame.Visible = true;

            currentTime = gameTime;
            GetAllQuestions();
            GameModeTwo();
            StartQuiz();

            pnlGame.Visible = true;
        }

        private void btnGamemodeThree_Click(object sender, EventArgs e)
        {
            pnlChooseGameMode.Visible = false;
            pnlGame.Visible = true;

            currentTime = gameTime;
            GetAllQuestions();
            GameModeThree();
            StartQuiz();

            pnlGame.Visible = true;
        }
    }
}