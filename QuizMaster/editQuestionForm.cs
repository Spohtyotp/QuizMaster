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
    public partial class editQuestionForm : Form
    {
        private int questionId;
        string connectionString =
        @"Data Source=localhost;Initial Catalog=quizmaster;User Id=root;password=''";

        public editQuestionForm(int id)
        {
            InitializeComponent();
            questionId = id;
            LoadQuestion();
        }

        private void editQuestionForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadQuestion()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "SELECT * FROM Questions WHERE QuestionID = @QuestionID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbxQuestion.Text = reader["Question"].ToString();
                            tbxCorrectAnswer.Text = reader["CorrectAnswer"].ToString();
                            tbxFalseOne.Text = reader["FalseAnswerOne"].ToString();
                            tbxFalseTwo.Text = reader["FalseAnswerTwo"].ToString();
                            tbxFalseThree.Text = reader["FalseAnswerThree"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxQuestion.Text) ||
               string.IsNullOrWhiteSpace(tbxCorrectAnswer.Text) ||
               string.IsNullOrWhiteSpace(tbxFalseOne.Text) ||
               string.IsNullOrWhiteSpace(tbxFalseTwo.Text) ||
               string.IsNullOrWhiteSpace(tbxFalseThree.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Questions SET " +
                    "Question = @Question, " +
                    "CorrectAnswer = @CorrectAnswer, " +
                    "FalseAnswerOne = @FalseAnswerOne, " +
                    "FalseAnswerTwo = @FalseAnswerTwo, " +
                    "FalseAnswerThree = @FalseAnswerThree " +
                    "WHERE QuestionID = @QuestionID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Question", tbxQuestion.Text);
                    cmd.Parameters.AddWithValue("@CorrectAnswer", tbxCorrectAnswer.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerOne", tbxFalseOne.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerTwo", tbxFalseTwo.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerThree", tbxFalseThree.Text);
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Question updated successfully!");
            this.Close();
        }
    }
}