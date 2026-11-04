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
                            tbxPlayerName.Text =
                                reader["PlayerName"].ToString();

                            tbxPassword.Text = reader["Password"].ToString();

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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPlayerName.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query;

                if (string.IsNullOrWhiteSpace(tbxPassword.Text))
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
                        "@PlayerName", tbxPlayerName.Text.Trim().ToLower());

                    cmd.Parameters.AddWithValue(
                       "@Password", tbxPassword.Text);

                    cmd.Parameters.AddWithValue(
                        "@IsAdmin", cbxIsAdmin.Checked);

                    cmd.Parameters.AddWithValue(
                        "@PlayerID", playerId);

                    if (!string.IsNullOrWhiteSpace(tbxPassword.Text))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Password", tbxPassword.Text);
                    }

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User updated successfully!");
            this.Close();
        }
    }
}