using System.Windows.Forms;

namespace QuizMaster
{
    partial class AddQuestionForm : Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxFalseThree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.tbxFalseTwo = new System.Windows.Forms.TextBox();
            this.tbxFalseOne = new System.Windows.Forms.TextBox();
            this.tbxCorrectAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuizMaster.Properties.Resources.kahoot2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tbxFalseThree);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCancelQuestion);
            this.panel1.Controls.Add(this.btnAddQuestion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCorrectAnswer);
            this.panel1.Controls.Add(this.tbxFalseTwo);
            this.panel1.Controls.Add(this.tbxFalseOne);
            this.panel1.Controls.Add(this.tbxCorrectAnswer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxQuestion);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 426);
            this.panel1.TabIndex = 2;
            // 
            // tbxFalseThree
            // 
            this.tbxFalseThree.Location = new System.Drawing.Point(80, 327);
            this.tbxFalseThree.Name = "tbxFalseThree";
            this.tbxFalseThree.Size = new System.Drawing.Size(100, 22);
            this.tbxFalseThree.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(34, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "False answer three";
            // 
            // btnCancelQuestion
            // 
            this.btnCancelQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelQuestion.Location = new System.Drawing.Point(158, 377);
            this.btnCancelQuestion.Name = "btnCancelQuestion";
            this.btnCancelQuestion.Size = new System.Drawing.Size(104, 35);
            this.btnCancelQuestion.TabIndex = 9;
            this.btnCancelQuestion.Text = "Cancel";
            this.btnCancelQuestion.UseVisualStyleBackColor = true;
            this.btnCancelQuestion.Click += new System.EventHandler(this.btnCancelQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddQuestion.Location = new System.Drawing.Point(15, 377);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(86, 35);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "False answer two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "False answer one";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCorrectAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(34, 85);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(192, 31);
            this.lblCorrectAnswer.TabIndex = 5;
            this.lblCorrectAnswer.Text = "Correct Answer";
            // 
            // tbxFalseTwo
            // 
            this.tbxFalseTwo.Location = new System.Drawing.Point(80, 256);
            this.tbxFalseTwo.Name = "tbxFalseTwo";
            this.tbxFalseTwo.Size = new System.Drawing.Size(100, 22);
            this.tbxFalseTwo.TabIndex = 4;
            // 
            // tbxFalseOne
            // 
            this.tbxFalseOne.Location = new System.Drawing.Point(80, 183);
            this.tbxFalseOne.Name = "tbxFalseOne";
            this.tbxFalseOne.Size = new System.Drawing.Size(100, 22);
            this.tbxFalseOne.TabIndex = 3;
            // 
            // tbxCorrectAnswer
            // 
            this.tbxCorrectAnswer.Location = new System.Drawing.Point(80, 119);
            this.tbxCorrectAnswer.Name = "tbxCorrectAnswer";
            this.tbxCorrectAnswer.Size = new System.Drawing.Size(100, 22);
            this.tbxCorrectAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(80, 46);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(100, 22);
            this.tbxQuestion.TabIndex = 0;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddQuestionForm";
            this.Text = "addQuestionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox tbxFalseTwo;
        private System.Windows.Forms.TextBox tbxFalseOne;
        private System.Windows.Forms.TextBox tbxCorrectAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Button btnCancelQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox tbxFalseThree;
        private System.Windows.Forms.Label label5;
    }
}