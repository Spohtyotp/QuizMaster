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
                            txtQuestion.Text = reader["Question"].ToString();
                            txtCorrectAnswer.Text = reader["CorrectAnswer"].ToString();
                            txtFalseAnswerOne.Text = reader["FalseAnswerOne"].ToString();
                            txtFalseAnswerTwo.Text = reader["FalseAnswerTwo"].ToString();
                            txtFalseAnswerThree.Text = reader["FalseAnswerThree"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
       string.IsNullOrWhiteSpace(txtCorrectAnswer.Text) ||
       string.IsNullOrWhiteSpace(txtFalseAnswerOne.Text) ||
       string.IsNullOrWhiteSpace(txtFalseAnswerTwo.Text) ||
       string.IsNullOrWhiteSpace(txtFalseAnswerThree.Text))
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
                    cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                    cmd.Parameters.AddWithValue("@CorrectAnswer", txtCorrectAnswer.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerOne", txtFalseAnswerOne.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerTwo", txtFalseAnswerTwo.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerThree", txtFalseAnswerThree.Text);
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Question updated successfully!");
            this.Close();
        }
    }
}
