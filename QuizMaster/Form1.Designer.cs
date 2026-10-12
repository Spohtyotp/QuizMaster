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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pcbTriangle = new System.Windows.Forms.PictureBox();
            this.pcbCircle = new System.Windows.Forms.PictureBox();
            this.pcbCube = new System.Windows.Forms.PictureBox();
            this.pcbDiamond = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiamond)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Controls.Add(this.tabPage3);
            this.tbControl.Location = new System.Drawing.Point(29, 39);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(744, 387);
            this.tbControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblQuestion);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.pcbTriangle);
            this.tabPage3.Controls.Add(this.pcbCircle);
            this.tabPage3.Controls.Add(this.pcbCube);
            this.tabPage3.Controls.Add(this.pcbDiamond);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(736, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "game";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pcbTriangle
            // 
            this.pcbTriangle.Image = global::QuizMaster.Properties.Resources.triangle;
            this.pcbTriangle.Location = new System.Drawing.Point(11, 130);
            this.pcbTriangle.Name = "pcbTriangle";
            this.pcbTriangle.Size = new System.Drawing.Size(353, 100);
            this.pcbTriangle.TabIndex = 5;
            this.pcbTriangle.TabStop = false;
            this.pcbTriangle.Click += new System.EventHandler(this.Answer_Click);
            // 
            // pcbCircle
            // 
            this.pcbCircle.Image = global::QuizMaster.Properties.Resources.circle;
            this.pcbCircle.Location = new System.Drawing.Point(12, 243);
            this.pcbCircle.Name = "pcbCircle";
            this.pcbCircle.Size = new System.Drawing.Size(352, 100);
            this.pcbCircle.TabIndex = 4;
            this.pcbCircle.TabStop = false;
            this.pcbCircle.Click += new System.EventHandler(this.Answer_Click);
            // 
            // pcbCube
            // 
            this.pcbCube.Image = global::QuizMaster.Properties.Resources.cubegreen;
            this.pcbCube.Location = new System.Drawing.Point(372, 243);
            this.pcbCube.Name = "pcbCube";
            this.pcbCube.Size = new System.Drawing.Size(352, 100);
            this.pcbCube.TabIndex = 2;
            this.pcbCube.TabStop = false;
            this.pcbCube.Click += new System.EventHandler(this.Answer_Click);
            // 
            // pcbDiamond
            // 
            this.pcbDiamond.Image = global::QuizMaster.Properties.Resources.cube;
            this.pcbDiamond.Location = new System.Drawing.Point(372, 130);
            this.pcbDiamond.Name = "pcbDiamond";
            this.pcbDiamond.Size = new System.Drawing.Size(353, 100);
            this.pcbDiamond.TabIndex = 1;
            this.pcbDiamond.TabStop = false;
            this.pcbDiamond.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(237, 4);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(16, 16);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "...";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiamond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pcbCube;
        private System.Windows.Forms.PictureBox pcbDiamond;
        private System.Windows.Forms.PictureBox pcbTriangle;
        private System.Windows.Forms.PictureBox pcbCircle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
    }
}

