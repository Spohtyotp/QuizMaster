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
            this.lblTimer.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 13);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "label5";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(12, 54);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(55, 13);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "label5";
            // 
            // btnAnswerOne
            // 
            this.btnAnswerOne.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerOne.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerOne.ForeColor = System.Drawing.Color.White;
            this.btnAnswerOne.Location = new System.Drawing.Point(118, 111);
            this.btnAnswerOne.Name = "btnAnswerOne";
            this.btnAnswerOne.Size = new System.Drawing.Size(231, 43);
            this.btnAnswerOne.TabIndex = 10;
            this.btnAnswerOne.Text = "button1";
            this.btnAnswerOne.UseVisualStyleBackColor = false;
            // 
            // btnAnswerFour
            // 
            this.btnAnswerFour.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerFour.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAnswerTwo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerTwo.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerTwo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnswerTwo.Location = new System.Drawing.Point(118, 167);
            this.btnAnswerTwo.Name = "btnAnswerTwo";
            this.btnAnswerTwo.Size = new System.Drawing.Size(231, 43);
            this.btnAnswerTwo.TabIndex = 11;
            this.btnAnswerTwo.Text = "button2";
            this.btnAnswerTwo.UseVisualStyleBackColor = false;
            // 
            // btnAnswerThree
            // 
            this.btnAnswerThree.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswerThree.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BackgroundImage = global::QuizMaster.Properties.Resources._1e8afa2de9c4da1fbb8b0ccdbbca34f0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 414);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerOne);
            this.Controls.Add(this.btnAnswerFour);
            this.Controls.Add(this.btnAnswerTwo);
            this.Controls.Add(this.btnAnswerThree);
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