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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbpRegister = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoginHere = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxRegisterPassword = new System.Windows.Forms.TextBox();
            this.cbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRegisterName = new System.Windows.Forms.TextBox();
            this.tbpLogin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxLoginName = new System.Windows.Forms.TextBox();
            this.btnRegisterHere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpGamemodes = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGameModeFour = new System.Windows.Forms.Button();
            this.btnGameModeThree = new System.Windows.Forms.Button();
            this.btnGameModeTwo = new System.Windows.Forms.Button();
            this.btnGameModeOne = new System.Windows.Forms.Button();
            this.tbpGame = new System.Windows.Forms.TabPage();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.lblQuestionTime = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnSkipQuestion = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerOne = new System.Windows.Forms.Button();
            this.btnAnswerFour = new System.Windows.Forms.Button();
            this.btnAnswerTwo = new System.Windows.Forms.Button();
            this.btnAnswerThree = new System.Windows.Forms.Button();
            this.tbpLeaderboard = new System.Windows.Forms.TabPage();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.tbpAdministrator = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tbControl.SuspendLayout();
            this.tbpRegister.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbpLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbpGamemodes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbpGame.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.tbpLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.tbpAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbpRegister);
            this.tbControl.Controls.Add(this.tbpLogin);
            this.tbControl.Controls.Add(this.tbpGamemodes);
            this.tbControl.Controls.Add(this.tbpGame);
            this.tbControl.Controls.Add(this.tbpLeaderboard);
            this.tbControl.Controls.Add(this.tbpAdministrator);
            this.tbControl.Location = new System.Drawing.Point(12, 25);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(776, 413);
            this.tbControl.TabIndex = 0;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tbpRegister
            // 
            this.tbpRegister.Controls.Add(this.panel2);
            this.tbpRegister.Location = new System.Drawing.Point(4, 25);
            this.tbpRegister.Name = "tbpRegister";
            this.tbpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegister.Size = new System.Drawing.Size(768, 384);
            this.tbpRegister.TabIndex = 1;
            this.tbpRegister.Text = "Register";
            this.tbpRegister.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuizMaster.Properties.Resources.kahoot2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnLoginHere);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.tbxRegisterPassword);
            this.panel2.Controls.Add(this.cbxIsAdmin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbxRegisterName);
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 340);
            this.panel2.TabIndex = 4;
            // 
            // btnLoginHere
            // 
            this.btnLoginHere.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoginHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoginHere.Location = new System.Drawing.Point(184, 220);
            this.btnLoginHere.Name = "btnLoginHere";
            this.btnLoginHere.Size = new System.Drawing.Size(138, 35);
            this.btnLoginHere.TabIndex = 3;
            this.btnLoginHere.Text = "Login Here";
            this.btnLoginHere.UseVisualStyleBackColor = true;
            this.btnLoginHere.Click += new System.EventHandler(this.btnLoginHere_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.CausesValidation = false;
            this.btnRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegister.Location = new System.Drawing.Point(33, 220);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 35);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxRegisterPassword
            // 
            this.tbxRegisterPassword.Location = new System.Drawing.Point(100, 137);
            this.tbxRegisterPassword.Name = "tbxRegisterPassword";
            this.tbxRegisterPassword.Size = new System.Drawing.Size(142, 22);
            this.tbxRegisterPassword.TabIndex = 1;
            // 
            // cbxIsAdmin
            // 
            this.cbxIsAdmin.AutoSize = true;
            this.cbxIsAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbxIsAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.cbxIsAdmin.Location = new System.Drawing.Point(42, 184);
            this.cbxIsAdmin.Name = "cbxIsAdmin";
            this.cbxIsAdmin.Size = new System.Drawing.Size(280, 30);
            this.cbxIsAdmin.TabIndex = 6;
            this.cbxIsAdmin.Text = "Administrator Account";
            this.cbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(115, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(95, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Name";
            // 
            // tbxRegisterName
            // 
            this.tbxRegisterName.Location = new System.Drawing.Point(100, 55);
            this.tbxRegisterName.Name = "tbxRegisterName";
            this.tbxRegisterName.Size = new System.Drawing.Size(142, 22);
            this.tbxRegisterName.TabIndex = 0;
            // 
            // tbpLogin
            // 
            this.tbpLogin.Controls.Add(this.panel1);
            this.tbpLogin.Location = new System.Drawing.Point(4, 25);
            this.tbpLogin.Name = "tbpLogin";
            this.tbpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLogin.Size = new System.Drawing.Size(768, 384);
            this.tbpLogin.TabIndex = 0;
            this.tbpLogin.Text = "Login";
            this.tbpLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuizMaster.Properties.Resources.kahoot2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbxLoginName);
            this.panel1.Controls.Add(this.btnRegisterHere);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxLoginPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Sans Serif Collection", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 344);
            this.panel1.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(206, 249);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login\r\n";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxLoginName
            // 
            this.tbxLoginName.Location = new System.Drawing.Point(99, 53);
            this.tbxLoginName.Name = "tbxLoginName";
            this.tbxLoginName.Size = new System.Drawing.Size(146, 42);
            this.tbxLoginName.TabIndex = 0;
            // 
            // btnRegisterHere
            // 
            this.btnRegisterHere.BackColor = System.Drawing.Color.White;
            this.btnRegisterHere.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegisterHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegisterHere.Location = new System.Drawing.Point(47, 249);
            this.btnRegisterHere.Name = "btnRegisterHere";
            this.btnRegisterHere.Size = new System.Drawing.Size(131, 40);
            this.btnRegisterHere.TabIndex = 3;
            this.btnRegisterHere.Text = "Register Here";
            this.btnRegisterHere.UseVisualStyleBackColor = false;
            this.btnRegisterHere.Click += new System.EventHandler(this.btnRegisterHere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player name";
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Location = new System.Drawing.Point(99, 146);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.Size = new System.Drawing.Size(146, 42);
            this.tbxLoginPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(117, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // tbpGamemodes
            // 
            this.tbpGamemodes.Controls.Add(this.panel3);
            this.tbpGamemodes.Location = new System.Drawing.Point(4, 25);
            this.tbpGamemodes.Name = "tbpGamemodes";
            this.tbpGamemodes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGamemodes.Size = new System.Drawing.Size(768, 384);
            this.tbpGamemodes.TabIndex = 5;
            this.tbpGamemodes.Text = "Gamemodes";
            this.tbpGamemodes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuizMaster.Properties.Resources.kahoot2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnGameModeFour);
            this.panel3.Controls.Add(this.btnGameModeThree);
            this.panel3.Controls.Add(this.btnGameModeTwo);
            this.panel3.Controls.Add(this.btnGameModeOne);
            this.panel3.Location = new System.Drawing.Point(21, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 348);
            this.panel3.TabIndex = 0;
            // 
            // btnGameModeFour
            // 
            this.btnGameModeFour.BackColor = System.Drawing.Color.White;
            this.btnGameModeFour.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGameModeFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGameModeFour.Location = new System.Drawing.Point(179, 233);
            this.btnGameModeFour.Name = "btnGameModeFour";
            this.btnGameModeFour.Size = new System.Drawing.Size(131, 40);
            this.btnGameModeFour.TabIndex = 7;
            this.btnGameModeFour.Text = "Special";
            this.btnGameModeFour.UseVisualStyleBackColor = false;
            this.btnGameModeFour.Click += new System.EventHandler(this.btnGameModeFour_Click);
            // 
            // btnGameModeThree
            // 
            this.btnGameModeThree.BackColor = System.Drawing.Color.White;
            this.btnGameModeThree.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGameModeThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGameModeThree.Location = new System.Drawing.Point(179, 138);
            this.btnGameModeThree.Name = "btnGameModeThree";
            this.btnGameModeThree.Size = new System.Drawing.Size(131, 40);
            this.btnGameModeThree.TabIndex = 6;
            this.btnGameModeThree.Text = "Books";
            this.btnGameModeThree.UseVisualStyleBackColor = false;
            this.btnGameModeThree.Click += new System.EventHandler(this.btnGameModeThree_Click);
            // 
            // btnGameModeTwo
            // 
            this.btnGameModeTwo.BackColor = System.Drawing.Color.White;
            this.btnGameModeTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGameModeTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGameModeTwo.Location = new System.Drawing.Point(179, 52);
            this.btnGameModeTwo.Name = "btnGameModeTwo";
            this.btnGameModeTwo.Size = new System.Drawing.Size(131, 40);
            this.btnGameModeTwo.TabIndex = 5;
            this.btnGameModeTwo.Text = "Games";
            this.btnGameModeTwo.UseVisualStyleBackColor = false;
            this.btnGameModeTwo.Click += new System.EventHandler(this.btnGameModeTwo_Click);
            // 
            // btnGameModeOne
            // 
            this.btnGameModeOne.BackColor = System.Drawing.Color.White;
            this.btnGameModeOne.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGameModeOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGameModeOne.Location = new System.Drawing.Point(27, 138);
            this.btnGameModeOne.Name = "btnGameModeOne";
            this.btnGameModeOne.Size = new System.Drawing.Size(131, 40);
            this.btnGameModeOne.TabIndex = 4;
            this.btnGameModeOne.Text = "Standard";
            this.btnGameModeOne.UseVisualStyleBackColor = false;
            this.btnGameModeOne.Click += new System.EventHandler(this.btnGameModeOne_Click);
            // 
            // tbpGame
            // 
            this.tbpGame.Controls.Add(this.pnlGame);
            this.tbpGame.Location = new System.Drawing.Point(4, 25);
            this.tbpGame.Name = "tbpGame";
            this.tbpGame.Size = new System.Drawing.Size(768, 384);
            this.tbpGame.TabIndex = 2;
            this.tbpGame.Text = "Game";
            this.tbpGame.UseVisualStyleBackColor = true;
            // 
            // pnlGame
            // 
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.Controls.Add(this.btnFiftyFifty);
            this.pnlGame.Controls.Add(this.lblQuestionTime);
            this.pnlGame.Controls.Add(this.lblTimer);
            this.pnlGame.Controls.Add(this.btnSkipQuestion);
            this.pnlGame.Controls.Add(this.lblQuestion);
            this.pnlGame.Controls.Add(this.btnAnswerOne);
            this.pnlGame.Controls.Add(this.btnAnswerFour);
            this.pnlGame.Controls.Add(this.btnAnswerTwo);
            this.pnlGame.Controls.Add(this.btnAnswerThree);
            this.pnlGame.Location = new System.Drawing.Point(3, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(739, 383);
            this.pnlGame.TabIndex = 1;
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFiftyFifty.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFiftyFifty.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFiftyFifty.Location = new System.Drawing.Point(619, 132);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(94, 46);
            this.btnFiftyFifty.TabIndex = 9;
            this.btnFiftyFifty.Text = "50/50";
            this.btnFiftyFifty.UseVisualStyleBackColor = false;
            this.btnFiftyFifty.Click += new System.EventHandler(this.btnFiftyFifty_Click);
            // 
            // lblQuestionTime
            // 
            this.lblQuestionTime.AutoSize = true;
            this.lblQuestionTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestionTime.ForeColor = System.Drawing.Color.White;
            this.lblQuestionTime.Location = new System.Drawing.Point(60, 142);
            this.lblQuestionTime.Name = "lblQuestionTime";
            this.lblQuestionTime.Size = new System.Drawing.Size(79, 26);
            this.lblQuestionTime.TabIndex = 8;
            this.lblQuestionTime.Text = "label5";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTimer.Location = new System.Drawing.Point(60, 184);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(79, 26);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "label5";
            // 
            // btnSkipQuestion
            // 
            this.btnSkipQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSkipQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSkipQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSkipQuestion.Location = new System.Drawing.Point(619, 184);
            this.btnSkipQuestion.Name = "btnSkipQuestion";
            this.btnSkipQuestion.Size = new System.Drawing.Size(94, 43);
            this.btnSkipQuestion.TabIndex = 6;
            this.btnSkipQuestion.Text = "Skip";
            this.btnSkipQuestion.UseVisualStyleBackColor = false;
            this.btnSkipQuestion.Click += new System.EventHandler(this.btnSkipQuestion_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(60, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(626, 66);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "label5";
            // 
            // btnAnswerOne
            // 
            this.btnAnswerOne.BackColor = System.Drawing.Color.White;
            this.btnAnswerOne.BackgroundImage = global::QuizMaster.Properties.Resources.triangle;
            this.btnAnswerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerOne.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnswerOne.ForeColor = System.Drawing.Color.White;
            this.btnAnswerOne.Location = new System.Drawing.Point(49, 234);
            this.btnAnswerOne.Name = "btnAnswerOne";
            this.btnAnswerOne.Size = new System.Drawing.Size(323, 71);
            this.btnAnswerOne.TabIndex = 2;
            this.btnAnswerOne.Text = "button1";
            this.btnAnswerOne.UseVisualStyleBackColor = false;
            // 
            // btnAnswerFour
            // 
            this.btnAnswerFour.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerFour.BackgroundImage = global::QuizMaster.Properties.Resources.circle;
            this.btnAnswerFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerFour.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnswerFour.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnswerFour.Location = new System.Drawing.Point(49, 310);
            this.btnAnswerFour.Name = "btnAnswerFour";
            this.btnAnswerFour.Size = new System.Drawing.Size(323, 68);
            this.btnAnswerFour.TabIndex = 5;
            this.btnAnswerFour.Text = "button4";
            this.btnAnswerFour.UseVisualStyleBackColor = false;
            // 
            // btnAnswerTwo
            // 
            this.btnAnswerTwo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerTwo.BackgroundImage = global::QuizMaster.Properties.Resources.cube;
            this.btnAnswerTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnswerTwo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnswerTwo.Location = new System.Drawing.Point(394, 233);
            this.btnAnswerTwo.Name = "btnAnswerTwo";
            this.btnAnswerTwo.Size = new System.Drawing.Size(319, 72);
            this.btnAnswerTwo.TabIndex = 3;
            this.btnAnswerTwo.Text = "button2";
            this.btnAnswerTwo.UseVisualStyleBackColor = false;
            // 
            // btnAnswerThree
            // 
            this.btnAnswerThree.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerThree.BackgroundImage = global::QuizMaster.Properties.Resources.cubegreen;
            this.btnAnswerThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerThree.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnswerThree.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnswerThree.Location = new System.Drawing.Point(394, 311);
            this.btnAnswerThree.Name = "btnAnswerThree";
            this.btnAnswerThree.Size = new System.Drawing.Size(319, 67);
            this.btnAnswerThree.TabIndex = 4;
            this.btnAnswerThree.Text = "button3";
            this.btnAnswerThree.UseVisualStyleBackColor = false;
            // 
            // tbpLeaderboard
            // 
            this.tbpLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.tbpLeaderboard.Location = new System.Drawing.Point(4, 25);
            this.tbpLeaderboard.Name = "tbpLeaderboard";
            this.tbpLeaderboard.Size = new System.Drawing.Size(768, 384);
            this.tbpLeaderboard.TabIndex = 3;
            this.tbpLeaderboard.Text = "Leaderboard";
            this.tbpLeaderboard.UseVisualStyleBackColor = true;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(14, 16);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.RowHeadersWidth = 51;
            this.dgvLeaderboard.RowTemplate.Height = 24;
            this.dgvLeaderboard.Size = new System.Drawing.Size(467, 365);
            this.dgvLeaderboard.TabIndex = 0;
            // 
            // tbpAdministrator
            // 
            this.tbpAdministrator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpAdministrator.BackgroundImage")));
            this.tbpAdministrator.Controls.Add(this.btnDeleteUser);
            this.tbpAdministrator.Controls.Add(this.btnEditUser);
            this.tbpAdministrator.Controls.Add(this.btnAddUser);
            this.tbpAdministrator.Controls.Add(this.dgvUsers);
            this.tbpAdministrator.Controls.Add(this.btnDeleteQuestion);
            this.tbpAdministrator.Controls.Add(this.btnEditQuestion);
            this.tbpAdministrator.Controls.Add(this.btnAddQuestion);
            this.tbpAdministrator.Controls.Add(this.dgvQuestions);
            this.tbpAdministrator.Location = new System.Drawing.Point(4, 25);
            this.tbpAdministrator.Name = "tbpAdministrator";
            this.tbpAdministrator.Size = new System.Drawing.Size(768, 384);
            this.tbpAdministrator.TabIndex = 4;
            this.tbpAdministrator.Text = "Administator";
            this.tbpAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteUser.Location = new System.Drawing.Point(638, 331);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(97, 38);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditUser.Location = new System.Drawing.Point(521, 331);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(97, 38);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Location = new System.Drawing.Point(403, 331);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(97, 38);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(388, 27);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(360, 276);
            this.dgvUsers.StandardTab = true;
            this.dgvUsers.TabIndex = 4;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(250, 332);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(97, 38);
            this.btnDeleteQuestion.TabIndex = 3;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditQuestion.Location = new System.Drawing.Point(130, 332);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(97, 38);
            this.btnEditQuestion.TabIndex = 2;
            this.btnEditQuestion.Text = "Edit ";
            this.btnEditQuestion.UseVisualStyleBackColor = false;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddQuestion.Location = new System.Drawing.Point(18, 331);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(97, 38);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(18, 27);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(348, 276);
            this.dgvQuestions.TabIndex = 0;
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
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
            this.tbpRegister.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbpLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbpGamemodes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tbpGame.ResumeLayout(false);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.tbpLeaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.tbpAdministrator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbpLogin;
        private System.Windows.Forms.TabPage tbpRegister;
        private System.Windows.Forms.TabPage tbpGame;
        private System.Windows.Forms.Button btnLoginHere;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxRegisterPassword;
        private System.Windows.Forms.TextBox tbxRegisterName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnAnswerFour;
        private System.Windows.Forms.Button btnAnswerThree;
        private System.Windows.Forms.Button btnAnswerTwo;
        private System.Windows.Forms.Button btnAnswerOne;
        private System.Windows.Forms.TabPage tbpLeaderboard;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Button btnSkipQuestion;
        private System.Windows.Forms.CheckBox cbxIsAdmin;
        private System.Windows.Forms.TabPage tbpAdministrator;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridView dgvUsers;
//        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestionTime;
        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegisterHere;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLoginName;
        private System.Windows.Forms.TextBox tbxLoginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tbpGamemodes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGameModeFour;
        private System.Windows.Forms.Button btnGameModeThree;
        private System.Windows.Forms.Button btnGameModeOne;
        private System.Windows.Forms.Button btnGameModeTwo;
    }
}

