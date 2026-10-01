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
            this.pcbDiamond = new System.Windows.Forms.PictureBox();
            this.pcbCube = new System.Windows.Forms.PictureBox();
            this.pcbCircle = new System.Windows.Forms.PictureBox();
            this.pcbTriangle = new System.Windows.Forms.PictureBox();
            this.tbControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangle)).BeginInit();
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
            // pcbDiamond
            // 
            this.pcbDiamond.Location = new System.Drawing.Point(372, 130);
            this.pcbDiamond.Name = "pcbDiamond";
            this.pcbDiamond.Size = new System.Drawing.Size(353, 100);
            this.pcbDiamond.TabIndex = 1;
            this.pcbDiamond.TabStop = false;
            // 
            // pcbCube
            // 
            this.pcbCube.Location = new System.Drawing.Point(372, 243);
            this.pcbCube.Name = "pcbCube";
            this.pcbCube.Size = new System.Drawing.Size(352, 100);
            this.pcbCube.TabIndex = 2;
            this.pcbCube.TabStop = false;
            // 
            // pcbCircle
            // 
            this.pcbCircle.Location = new System.Drawing.Point(12, 243);
            this.pcbCircle.Name = "pcbCircle";
            this.pcbCircle.Size = new System.Drawing.Size(352, 100);
            this.pcbCircle.TabIndex = 4;
            this.pcbCircle.TabStop = false;
            // 
            // pcbTriangle
            // 
            this.pcbTriangle.Location = new System.Drawing.Point(11, 130);
            this.pcbTriangle.Name = "pcbTriangle";
            this.pcbTriangle.Size = new System.Drawing.Size(353, 100);
            this.pcbTriangle.TabIndex = 5;
            this.pcbTriangle.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangle)).EndInit();
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
    }
}

