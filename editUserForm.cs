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
    public partial class editUserForm : Form
    {
        private int playerId;

        string connectionString = @"Data Source=localhost;Initial Catalog=quizmaster;User Id=root;password=''";
        public editUserForm(int id)
        {
            InitializeComponent();

            playerId = id;

            LoadUser();
        }

        private void editUserForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadUser()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "SELECT PlayerName, Password, IsAdmin FROM login " +
                    "WHERE PlayerID = @PlayerID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerID", playerId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text =
                                reader["PlayerName"].ToString();

                            txtPassword.Text = reader["Password"].ToString();

                            cbxIsAdmin.Checked =
                                Convert.ToBoolean(reader["IsAdmin"]);
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                            this.Close();
                        }
                    }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query;

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    query =
                        "UPDATE login SET " +
                        "PlayerName = @PlayerName, " +
                        "IsAdmin = @IsAdmin " +
                        "WHERE PlayerID = @PlayerID";
                }
                else
                {
                    query =
                        "UPDATE login SET " +
                        "PlayerName = @PlayerName, " +
                        "Password = @Password, " +
                        "IsAdmin = @IsAdmin " +
                        "WHERE PlayerID = @PlayerID";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@PlayerName", txtUsername.Text.Trim().ToLower());

                    cmd.Parameters.AddWithValue(
                        "@IsAdmin", cbxIsAdmin.Checked);

                    cmd.Parameters.AddWithValue(
                        "@PlayerID", playerId);

                    // Only add password if the user entered one
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Password", txtPassword.Text);
                    }

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User updated successfully!");
            this.Close();
        }
    }
}
