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
    public partial class AddQuestionForm : Form
    {
        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check that all fields have been filled in
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtCorrectAnswer.Text) ||
                string.IsNullOrWhiteSpace(txtFalseAnswerOne.Text) ||
                string.IsNullOrWhiteSpace(txtFalseAnswerTwo.Text) ||
                string.IsNullOrWhiteSpace(txtFalseAnswerThree.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Questions " +
                               "(Question, CorrectAnswer, FalseAnswerOne, FalseAnswerTwo, FalseAnswerThree) " +
                               "VALUES " +
                               "(@Question, @CorrectAnswer, @FalseAnswerOne, @FalseAnswerTwo, @FalseAnswerThree)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                    cmd.Parameters.AddWithValue("@CorrectAnswer", txtCorrectAnswer.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerOne", txtFalseAnswerOne.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerTwo", txtFalseAnswerTwo.Text);
                    cmd.Parameters.AddWithValue("@FalseAnswerThree", txtFalseAnswerThree.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Question added successfully!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
