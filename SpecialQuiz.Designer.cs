namespace QuizMaster
{
    partial class SpecialQuiz
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerOne = new System.Windows.Forms.Button();
            this.btnAnswerFour = new System.Windows.Forms.Button();
            this.btnAnswerTwo = new System.Windows.Forms.Button();
            this.btnAnswerThree = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(68, 22);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "label5";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(12, 54);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(462, 44);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "label5";
            // 
            // btnAnswerOne
            // 
            this.btnAnswerOne.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswerOne.FlatAppearance.BorderSize = 5;
            this.btnAnswerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerOne.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnswerOne.ForeColor = System.Drawing.Color.White;
            this.btnAnswerOne.Location = new System.Drawing.Point(118, 111);
            this.btnAnswerOne.Name = "btnAnswerOne";
            this.btnAnswerOne.Size = new System.Drawing.Size(231, 43);
            this.btnAnswerOne.TabIndex = 10;
            this.btnAnswerOne.Text = "button1";
            this.btnAnswerOne.UseVisualStyleBackColor = false;
            this.btnAnswerOne.Click += new System.EventHandler(this.btnAnswerOne_Click);
            // 
            // btnAnswerFour
            // 
            this.btnAnswerFour.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswerFour.FlatAppearance.BorderSize = 5;
            this.btnAnswerFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerFour.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnswerFour.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnswerFour.Location = new System.Drawing.Point(118, 285);
            this.btnAnswerFour.Name = "btnAnswerFour";
            this.btnAnswerFour.Size = new System.Drawing.Size(231, 43);
            this.btnAnswerFour.TabIndex = 13;
            this.btnAnswerFour.Text = "button4";
            this.btnAnswerFour.UseVisualStyleBackColor = false;
            // 
            // btnAnswerTwo
            // 
            this.btnAnswerTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswerTwo.FlatAppearance.BorderSize = 5;
            this.btnAnswerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnswerTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnswerTwo.Location = new System.Drawing.Point(118, 167);
            this.btnAnswerTwo.Name = "btnAnswerTwo";
            this.btnAnswerTwo.Size = new System.Drawing.Size(231, 43);
            this.btnAnswerTwo.TabIndex = 11;
            this.btnAnswerTwo.Text = "button2";
            this.btnAnswerTwo.UseVisualStyleBackColor = false;
            // 
            // btnAnswerThree
            // 
            this.btnAnswerThree.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswerThree.FlatAppearance.BorderSize = 5;
            this.btnAnswerThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerThree.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnswerThree.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnswerThree.Location = new System.Drawing.Point(118, 228);
            this.btnAnswerThree.Name = "btnAnswerThree";
            this.btnAnswerThree.Size = new System.Drawing.Size(231, 43);
            this.btnAnswerThree.TabIndex = 12;
            this.btnAnswerThree.Text = "button3";
            this.btnAnswerThree.UseVisualStyleBackColor = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // SpecialQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizMaster.Properties.Resources.kahoot2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 414);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerOne);
            this.Controls.Add(this.btnAnswerFour);
            this.Controls.Add(this.btnAnswerTwo);
            this.Controls.Add(this.btnAnswerThree);
            this.DoubleBuffered = true;
            this.Name = "SpecialQuiz";
            this.Text = "SpecialQuiz";
            this.Load += new System.EventHandler(this.SpecialQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerOne;
        private System.Windows.Forms.Button btnAnswerFour;
        private System.Windows.Forms.Button btnAnswerTwo;
        private System.Windows.Forms.Button btnAnswerThree;
        private System.Windows.Forms.Timer tmrGame;
    }
}