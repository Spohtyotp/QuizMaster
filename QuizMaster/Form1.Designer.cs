namespace QuizMaster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbRegister = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.tbxRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbxRegister = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbGame = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbChooseGamemode = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGamemodeThree = new System.Windows.Forms.Button();
            this.btnGamemodeTwo = new System.Windows.Forms.Button();
            this.btnGamemodeOne = new System.Windows.Forms.Button();
            this.leaderboard = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tbControl.SuspendLayout();
            this.tbRegister.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.tbGame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbChooseGamemode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.leaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbRegister);
            this.tbControl.Controls.Add(this.tbLogin);
            this.tbControl.Controls.Add(this.tbGame);
            this.tbControl.Controls.Add(this.tbChooseGamemode);
            this.tbControl.Controls.Add(this.leaderboard);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Location = new System.Drawing.Point(29, 39);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(744, 387);
            this.tbControl.TabIndex = 0;
            // 
            // tbRegister
            // 
            this.tbRegister.Controls.Add(this.btnRegister);
            this.tbRegister.Controls.Add(this.cbxIsAdmin);
            this.tbRegister.Controls.Add(this.tbxRegisterPassword);
            this.tbRegister.Controls.Add(this.tbxRegister);
            this.tbRegister.Location = new System.Drawing.Point(4, 25);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegister.Size = new System.Drawing.Size(736, 358);
            this.tbRegister.TabIndex = 0;
            this.tbRegister.Text = "register";
            this.tbRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(107, 244);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbxIsAdmin
            // 
            this.cbxIsAdmin.AutoSize = true;
            this.cbxIsAdmin.Location = new System.Drawing.Point(232, 130);
            this.cbxIsAdmin.Name = "cbxIsAdmin";
            this.cbxIsAdmin.Size = new System.Drawing.Size(67, 20);
            this.cbxIsAdmin.TabIndex = 2;
            this.cbxIsAdmin.Text = "Admin";
            this.cbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // tbxRegisterPassword
            // 
            this.tbxRegisterPassword.Location = new System.Drawing.Point(107, 177);
            this.tbxRegisterPassword.Name = "tbxRegisterPassword";
            this.tbxRegisterPassword.Size = new System.Drawing.Size(100, 22);
            this.tbxRegisterPassword.TabIndex = 1;
            // 
            // tbxRegister
            // 
            this.tbxRegister.Location = new System.Drawing.Point(107, 128);
            this.tbxRegister.Name = "tbxRegister";
            this.tbxRegister.Size = new System.Drawing.Size(100, 22);
            this.tbxRegister.TabIndex = 0;
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.btnLogin);
            this.tbLogin.Controls.Add(this.tbxLoginPassword);
            this.tbLogin.Controls.Add(this.tbxLogin);
            this.tbLogin.Location = new System.Drawing.Point(4, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogin.Size = new System.Drawing.Size(736, 358);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "login";
            this.tbLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(86, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Location = new System.Drawing.Point(86, 161);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.Size = new System.Drawing.Size(100, 22);
            this.tbxLoginPassword.TabIndex = 1;
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(86, 119);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(100, 22);
            this.tbxLogin.TabIndex = 0;
            // 
            // tbGame
            // 
            this.tbGame.Controls.Add(this.panel1);
            this.tbGame.Location = new System.Drawing.Point(4, 25);
            this.tbGame.Name = "tbGame";
            this.tbGame.Size = new System.Drawing.Size(736, 358);
            this.tbGame.TabIndex = 2;
            this.tbGame.Text = "game";
            this.tbGame.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuizMaster.Properties.Resources.kahootbackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Location = new System.Drawing.Point(-4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 355);
            this.panel1.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::QuizMaster.Properties.Resources.cubegreen;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(375, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 93);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::QuizMaster.Properties.Resources.circle;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(19, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 93);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::QuizMaster.Properties.Resources.cube;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(375, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 93);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCircle.Image = global::QuizMaster.Properties.Resources.triangle;
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCircle.Location = new System.Drawing.Point(19, 152);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(350, 93);
            this.btnCircle.TabIndex = 12;
            this.btnCircle.Text = "button1";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(338, 105);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(83, 31);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "label5";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(338, 21);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(69, 31);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "label";
            // 
            // tbChooseGamemode
            // 
            this.tbChooseGamemode.Controls.Add(this.panel2);
            this.tbChooseGamemode.Location = new System.Drawing.Point(4, 25);
            this.tbChooseGamemode.Name = "tbChooseGamemode";
            this.tbChooseGamemode.Padding = new System.Windows.Forms.Padding(3);
            this.tbChooseGamemode.Size = new System.Drawing.Size(736, 358);
            this.tbChooseGamemode.TabIndex = 3;
            this.tbChooseGamemode.Text = "gamemode";
            this.tbChooseGamemode.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuizMaster.Properties.Resources.kahootbackground;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnGamemodeThree);
            this.panel2.Controls.Add(this.btnGamemodeTwo);
            this.panel2.Controls.Add(this.btnGamemodeOne);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 345);
            this.panel2.TabIndex = 0;
            // 
            // btnGamemodeThree
            // 
            this.btnGamemodeThree.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGamemodeThree.Location = new System.Drawing.Point(505, 31);
            this.btnGamemodeThree.Name = "btnGamemodeThree";
            this.btnGamemodeThree.Size = new System.Drawing.Size(145, 58);
            this.btnGamemodeThree.TabIndex = 2;
            this.btnGamemodeThree.Text = "Books";
            this.btnGamemodeThree.UseVisualStyleBackColor = true;
            this.btnGamemodeThree.Click += new System.EventHandler(this.btnGamemodeThree_Click);
            // 
            // btnGamemodeTwo
            // 
            this.btnGamemodeTwo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGamemodeTwo.Location = new System.Drawing.Point(78, 30);
            this.btnGamemodeTwo.Name = "btnGamemodeTwo";
            this.btnGamemodeTwo.Size = new System.Drawing.Size(145, 59);
            this.btnGamemodeTwo.TabIndex = 1;
            this.btnGamemodeTwo.Text = "Games";
            this.btnGamemodeTwo.UseVisualStyleBackColor = true;
            this.btnGamemodeTwo.Click += new System.EventHandler(this.btnGamemodeTwo_Click);
            // 
            // btnGamemodeOne
            // 
            this.btnGamemodeOne.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGamemodeOne.Location = new System.Drawing.Point(292, 30);
            this.btnGamemodeOne.Name = "btnGamemodeOne";
            this.btnGamemodeOne.Size = new System.Drawing.Size(145, 58);
            this.btnGamemodeOne.TabIndex = 0;
            this.btnGamemodeOne.Text = "Standard";
            this.btnGamemodeOne.UseVisualStyleBackColor = true;
            this.btnGamemodeOne.Click += new System.EventHandler(this.btnGamemodeOne_Click);
            // 
            // leaderboard
            // 
            this.leaderboard.Controls.Add(this.dataGridView1);
            this.leaderboard.Location = new System.Drawing.Point(4, 25);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.leaderboard.Size = new System.Drawing.Size(736, 358);
            this.leaderboard.TabIndex = 4;
            this.leaderboard.Text = "leaderboard";
            this.leaderboard.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(367, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 358);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "administrator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(379, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(351, 257);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(351, 257);
            this.dataGridView2.TabIndex = 0;
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(141, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(250, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(402, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(515, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(626, 50);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbControl.ResumeLayout(false);
            this.tbRegister.ResumeLayout(false);
            this.tbRegister.PerformLayout();
            this.tbLogin.ResumeLayout(false);
            this.tbLogin.PerformLayout();
            this.tbGame.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbChooseGamemode.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.leaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbRegister;
        private System.Windows.Forms.TabPage tbLogin;
        private System.Windows.Forms.TabPage tbGame;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox cbxIsAdmin;
        private System.Windows.Forms.TextBox tbxRegisterPassword;
        private System.Windows.Forms.TextBox tbxRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxLoginPassword;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.TabPage tbChooseGamemode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGamemodeThree;
        private System.Windows.Forms.Button btnGamemodeTwo;
        private System.Windows.Forms.Button btnGamemodeOne;
        private System.Windows.Forms.TabPage leaderboard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}

