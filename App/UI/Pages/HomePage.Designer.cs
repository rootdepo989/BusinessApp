namespace App
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            pictureBoxGoParumesPage = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoParumesPage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGoParumesPage
            // 
            pictureBoxGoParumesPage.BackColor = System.Drawing.Color.Transparent;
            pictureBoxGoParumesPage.Image = (System.Drawing.Image)resources.GetObject("pictureBoxGoParumesPage.Image");
            pictureBoxGoParumesPage.Location = new System.Drawing.Point(37, 130);
            pictureBoxGoParumesPage.Name = "pictureBoxGoParumesPage";
            pictureBoxGoParumesPage.Size = new System.Drawing.Size(101, 83);
            pictureBoxGoParumesPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxGoParumesPage.TabIndex = 3;
            pictureBoxGoParumesPage.TabStop = false;
            pictureBoxGoParumesPage.Click += pictureBoxGoParumesPage_Click;
            pictureBoxGoParumesPage.MouseHover += pictureBoxGoParumesPage_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(37, 216);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 15);
            label1.TabIndex = 4;
            label1.Text = "ƏTİR TİCARƏTİM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(309, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(224, 17);
            label2.TabIndex = 5;
            label2.Text = "RASİM bəy bütün işləriniz buradadır";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxGoParumesPage);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += HomePage_FormClosing;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoParumesPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxGoParumesPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}