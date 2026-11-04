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
    public partial class addUserForm : Form
    {
        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";
        public addUserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsername.Text) ||
               string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "INSERT INTO login (PlayerName, Password, IsAdmin) " +
                    "VALUES (@PlayerName, @Password, @IsAdmin)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@PlayerName", txbUsername.Text.Trim().ToLower());

                    cmd.Parameters.AddWithValue(
                        "@Password", txbPassword.Text);

                    cmd.Parameters.AddWithValue(
                        "@IsAdmin", cbxIsAdmin.Checked);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User added successfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}