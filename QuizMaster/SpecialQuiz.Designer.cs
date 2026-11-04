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
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnDiamond = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquare.Image = global::QuizMaster.Properties.Resources.cubegreen;
            this.btnSquare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSquare.Location = new System.Drawing.Point(403, 294);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(350, 93);
            this.btnSquare.TabIndex = 21;
            this.btnSquare.Text = "button4";
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCircle.Image = global::QuizMaster.Properties.Resources.circle;
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCircle.Location = new System.Drawing.Point(47, 294);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(350, 93);
            this.btnCircle.TabIndex = 20;
            this.btnCircle.Text = "button3";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnDiamond
            // 
            this.btnDiamond.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDiamond.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiamond.Image = global::QuizMaster.Properties.Resources.cube;
            this.btnDiamond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiamond.Location = new System.Drawing.Point(403, 195);
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(350, 93);
            this.btnDiamond.TabIndex = 19;
            this.btnDiamond.Text = "button2";
            this.btnDiamond.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTriangle.Image = global::QuizMaster.Properties.Resources.triangle;
            this.btnTriangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriangle.Location = new System.Drawing.Point(47, 195);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(350, 93);
            this.btnTriangle.TabIndex = 18;
            this.btnTriangle.Text = "button1";
            this.btnTriangle.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(366, 149);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(83, 31);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "label5";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(12, 24);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(69, 31);
            this.lblQuestion.TabIndex = 16;
            this.lblQuestion.Text = "label";
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // SpecialQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizMaster.Properties.Resources.kahootbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnDiamond);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "SpecialQuiz";
            this.Text = "SpecialQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnDiamond;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer tmrGame;
    }
}