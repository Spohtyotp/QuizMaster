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
            this.btnSkipQuestion = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnDiamond = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbChooseGamemode = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGamemodeBooks = new System.Windows.Forms.Button();
            this.btnGamemodeStandard = new System.Windows.Forms.Button();
            this.btnGamemodeGames = new System.Windows.Forms.Button();
            this.tbpLeaderboard = new System.Windows.Forms.TabPage();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.tbpAdministrator = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.btnGamemodeThree = new System.Windows.Forms.Button();
            this.btnGamemodeTwo = new System.Windows.Forms.Button();
            this.btnGamemodeOne = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tbControl.SuspendLayout();
            this.tbRegister.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.tbGame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbChooseGamemode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbpLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.tbpAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbRegister);
            this.tbControl.Controls.Add(this.tbLogin);
            this.tbControl.Controls.Add(this.tbGame);
            this.tbControl.Controls.Add(this.tbChooseGamemode);
            this.tbControl.Controls.Add(this.tbpLeaderboard);
            this.tbControl.Controls.Add(this.tbpAdministrator);
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
            this.panel1.Controls.Add(this.btnSkipQuestion);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnDiamond);
            this.panel1.Controls.Add(this.btnTriangle);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Location = new System.Drawing.Point(-4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 355);
            this.panel1.TabIndex = 12;
            // 
            // btnSkipQuestion
            // 
            this.btnSkipQuestion.BackgroundImage = global::QuizMaster.Properties.Resources.kahoot2;
            this.btnSkipQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSkipQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSkipQuestion.Location = new System.Drawing.Point(625, 100);
            this.btnSkipQuestion.Name = "btnSkipQuestion";
            this.btnSkipQuestion.Size = new System.Drawing.Size(100, 37);
            this.btnSkipQuestion.TabIndex = 16;
            this.btnSkipQuestion.Text = "Skip";
            this.btnSkipQuestion.UseVisualStyleBackColor = true;
            this.btnSkipQuestion.Click += new System.EventHandler(this.btnSkipQuestion_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquare.Image = global::QuizMaster.Properties.Resources.cubegreen;
            this.btnSquare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSquare.Location = new System.Drawing.Point(375, 251);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(350, 93);
            this.btnSquare.TabIndex = 15;
            this.btnSquare.Text = "button4";
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCircle.Image = global::QuizMaster.Properties.Resources.circle;
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCircle.Location = new System.Drawing.Point(19, 251);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(350, 93);
            this.btnCircle.TabIndex = 14;
            this.btnCircle.Text = "button3";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnDiamond
            // 
            this.btnDiamond.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDiamond.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiamond.Image = global::QuizMaster.Properties.Resources.cube;
            this.btnDiamond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiamond.Location = new System.Drawing.Point(375, 152);
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(350, 93);
            this.btnDiamond.TabIndex = 13;
            this.btnDiamond.Text = "button2";
            this.btnDiamond.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTriangle.Image = global::QuizMaster.Properties.Resources.triangle;
            this.btnTriangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriangle.Location = new System.Drawing.Point(19, 152);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(350, 93);
            this.btnTriangle.TabIndex = 12;
            this.btnTriangle.Text = "button1";
            this.btnTriangle.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(338, 106);
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
            this.panel2.Controls.Add(this.btnGamemodeBooks);
            this.panel2.Controls.Add(this.btnGamemodeStandard);
            this.panel2.Controls.Add(this.btnGamemodeGames);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 345);
            this.panel2.TabIndex = 0;
            // 
            // btnGamemodeBooks
            // 
            this.btnGamemodeBooks.Location = new System.Drawing.Point(461, 45);
            this.btnGamemodeBooks.Name = "btnGamemodeBooks";
            this.btnGamemodeBooks.Size = new System.Drawing.Size(128, 43);
            this.btnGamemodeBooks.TabIndex = 2;
            this.btnGamemodeBooks.Text = "Books";
            this.btnGamemodeBooks.UseVisualStyleBackColor = true;
            this.btnGamemodeBooks.Click += new System.EventHandler(this.btnGamemodeBooks_Click);
            // 
            // btnGamemodeStandard
            // 
            this.btnGamemodeStandard.Location = new System.Drawing.Point(275, 45);
            this.btnGamemodeStandard.Name = "btnGamemodeStandard";
            this.btnGamemodeStandard.Size = new System.Drawing.Size(128, 43);
            this.btnGamemodeStandard.TabIndex = 1;
            this.btnGamemodeStandard.Text = "Standard";
            this.btnGamemodeStandard.UseVisualStyleBackColor = true;
            this.btnGamemodeStandard.Click += new System.EventHandler(this.btnGamemodeStandard_Click);
            // 
            // btnGamemodeGames
            // 
            this.btnGamemodeGames.Location = new System.Drawing.Point(98, 45);
            this.btnGamemodeGames.Name = "btnGamemodeGames";
            this.btnGamemodeGames.Size = new System.Drawing.Size(128, 43);
            this.btnGamemodeGames.TabIndex = 0;
            this.btnGamemodeGames.Text = "Games";
            this.btnGamemodeGames.UseVisualStyleBackColor = true;
            this.btnGamemodeGames.Click += new System.EventHandler(this.btnGamemodeGames_Click_1);
            // 
            // tbpLeaderboard
            // 
            this.tbpLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.tbpLeaderboard.Location = new System.Drawing.Point(4, 25);
            this.tbpLeaderboard.Name = "tbpLeaderboard";
            this.tbpLeaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLeaderboard.Size = new System.Drawing.Size(736, 358);
            this.tbpLeaderboard.TabIndex = 4;
            this.tbpLeaderboard.Text = "leaderboard";
            this.tbpLeaderboard.UseVisualStyleBackColor = true;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(7, 7);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.RowHeadersWidth = 51;
            this.dgvLeaderboard.RowTemplate.Height = 24;
            this.dgvLeaderboard.Size = new System.Drawing.Size(367, 348);
            this.dgvLeaderboard.TabIndex = 0;
            // 
            // tbpAdministrator
            // 
            this.tbpAdministrator.Controls.Add(this.btnDeleteUser);
            this.tbpAdministrator.Controls.Add(this.btnEditUser);
            this.tbpAdministrator.Controls.Add(this.btnAddUser);
            this.tbpAdministrator.Controls.Add(this.btnDeleteQuestion);
            this.tbpAdministrator.Controls.Add(this.btnEditQuestion);
            this.tbpAdministrator.Controls.Add(this.btnAddQuestion);
            this.tbpAdministrator.Controls.Add(this.dgvUsers);
            this.tbpAdministrator.Controls.Add(this.dgvQuestions);
            this.tbpAdministrator.Location = new System.Drawing.Point(4, 25);
            this.tbpAdministrator.Name = "tbpAdministrator";
            this.tbpAdministrator.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdministrator.Size = new System.Drawing.Size(736, 358);
            this.tbpAdministrator.TabIndex = 5;
            this.tbpAdministrator.Text = "administrator";
            this.tbpAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(626, 50);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(515, 50);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(402, 50);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(250, 50);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteQuestion.TabIndex = 4;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(141, 50);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnEditQuestion.TabIndex = 3;
            this.btnEditQuestion.Text = "Edit";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(43, 50);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(379, 95);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(351, 257);
            this.dgvUsers.TabIndex = 1;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(6, 95);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.Size = new System.Drawing.Size(351, 257);
            this.dgvQuestions.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(803, 449);
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
            this.tbpLeaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.tbpAdministrator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
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
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnDiamond;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.TabPage tbChooseGamemode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGamemodeThree;
        private System.Windows.Forms.Button btnGamemodeTwo;
        private System.Windows.Forms.Button btnGamemodeOne;
        private System.Windows.Forms.TabPage tbpLeaderboard;
        private System.Windows.Forms.TabPage tbpAdministrator;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnGamemodeBooks;
        private System.Windows.Forms.Button btnGamemodeStandard;
        private System.Windows.Forms.Button btnGamemodeGames;
        private System.Windows.Forms.Button btnSkipQuestion;
    }
}

