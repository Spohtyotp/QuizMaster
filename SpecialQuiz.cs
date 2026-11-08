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
    public partial class SpecialQuiz : Form
    {
        int currentTime = 0;
        int score = 0;
        int row = 0;
        string playerName;

        const int questionsToWin = 10;
        const int penaltySeconds = 5;
        DataTable dataTable = null;

        Question question = null;
        List<Question> questionList = null;
        List<Question> currentQuestions = null;

        Random random = new Random();
        int currentQuestion = 0;
        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";

        public SpecialQuiz(string loggedInPlayer)
        {
            InitializeComponent();

            playerName = loggedInPlayer;

            tmrGame.Interval = 1000;

            btnAnswerOne.Click += CheckAnswer;
            btnAnswerTwo.Click += CheckAnswer;
            btnAnswerThree.Click += CheckAnswer;
            btnAnswerFour.Click += CheckAnswer;
        }
        private void SpecialQuiz_Load(object sender, EventArgs e)
        {
            GetAllQuestions();

            currentQuestions = questionList.ToList();

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
            currentTime = 0;

            lblTimer.Text = "Time: 00:00";
            lblTimer.ForeColor = Color.White;

            DisplayQuestion();

            tmrGame.Start();
        }

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
            btnAnswerOne.Text = answers[0];
            btnAnswerTwo.Text = answers[1];
            btnAnswerThree.Text = answers[2];
            btnAnswerFour.Text = answers[3];
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            currentTime++;

            TimeSpan time = TimeSpan.FromSeconds(currentTime);

            lblTimer.Text = "Time: " + time.ToString(@"mm\:ss");
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string correctAnswer =
                currentQuestions[currentQuestion].GetCorrectAnswer();

            if (clickedButton.Text == correctAnswer)
            {
                score++;
            }
            else
            {
                // Add 5 seconds for an incorrect answer
                currentTime += penaltySeconds;

                TimeSpan time = TimeSpan.FromSeconds(currentTime);
                lblTimer.Text = "Time: " + time.ToString(@"mm\:ss");
            }

            // Check whether the player has answered 10 questions correctly
            if (score >= questionsToWin)
            {
                FinishQuiz();
                return;
            }

            // Move to the next question
            currentQuestion++;

            // If all questions have been used, shuffle them again
            if (currentQuestion >= currentQuestions.Count)
            {
                ShuffleList();
                currentQuestion = 0;
            }

            DisplayQuestion();
        }

        private void FinishQuiz()
        {
            tmrGame.Stop();

            int? fastestTime = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Get the previous fastest time
                string selectQuery = "SELECT MIN(CompletionTime) FROM specialquiz_record";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    object result = cmd.ExecuteScalar();

                    //check if there is a previous fastest time
                    if (result != DBNull.Value)
                    {
                        fastestTime = Convert.ToInt32(result);
                    }
                }

                // Save this player's completion time
                string insertQuery =
                    "INSERT INTO specialquiz_record " +
                    "(PlayerName, CompletionTime, Date) " +
                    "VALUES (@PlayerName, @CompletionTime, @Date)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerName", playerName);
                    cmd.Parameters.AddWithValue("@CompletionTime", currentTime);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }

            TimeSpan playerTime = TimeSpan.FromSeconds(currentTime);

            string message =
                "Quiz completed!\n\n" +
                "Your time: " + playerTime.ToString(@"mm\:ss");

            // Check if the player achieved the fastest time
            if (fastestTime == null || currentTime < fastestTime.Value)
            {
                message += "\n\nCongratulations! You achieved the fastest time ever!";
            }
            else
            {
                TimeSpan recordTime = TimeSpan.FromSeconds(fastestTime.Value);

                message += "\nFastest time ever: " +
                           recordTime.ToString(@"mm\:ss");
            }

            MessageBox.Show(message);

            this.Close();
        }
    }
}
