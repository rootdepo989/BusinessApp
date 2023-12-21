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
            label2 = new System.Windows.Forms.Label();
            buttonGoOtherWorkPages = new System.Windows.Forms.PictureBox();
            buttonGoParfumeBusinessPage = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)buttonGoOtherWorkPages).BeginInit();
            SuspendLayout();
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
            // buttonGoOtherWorkPages
            // 
            buttonGoOtherWorkPages.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonGoOtherWorkPages.Image = (System.Drawing.Image)resources.GetObject("buttonGoOtherWorkPages.Image");
            buttonGoOtherWorkPages.Location = new System.Drawing.Point(0, 0);
            buttonGoOtherWorkPages.Name = "buttonGoOtherWorkPages";
            buttonGoOtherWorkPages.Size = new System.Drawing.Size(800, 450);
            buttonGoOtherWorkPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            buttonGoOtherWorkPages.TabIndex = 6;
            buttonGoOtherWorkPages.TabStop = false;
            // 
            // buttonGoParfumeBusinessPage
            // 
            buttonGoParfumeBusinessPage.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonGoParfumeBusinessPage.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonGoParfumeBusinessPage.BackgroundImage");
            buttonGoParfumeBusinessPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoParfumeBusinessPage.ForeColor = System.Drawing.Color.Lime;
            buttonGoParfumeBusinessPage.Location = new System.Drawing.Point(338, 214);
            buttonGoParfumeBusinessPage.Name = "buttonGoParfumeBusinessPage";
            buttonGoParfumeBusinessPage.Size = new System.Drawing.Size(95, 75);
            buttonGoParfumeBusinessPage.TabIndex = 7;
            buttonGoParfumeBusinessPage.Text = "ƏTİRLƏR";
            buttonGoParfumeBusinessPage.UseVisualStyleBackColor = false;
            buttonGoParfumeBusinessPage.Click += buttonGoParfumeBusinessPage_Click;
            buttonGoParfumeBusinessPage.MouseHover += buttonGoParfumeBusinessPage_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Lime;
            button1.Location = new System.Drawing.Point(428, 143);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(95, 74);
            button1.TabIndex = 8;
            button1.Text = "DİŞ PASTALARI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonGoParfumeBusinessPage);
            Controls.Add(buttonGoOtherWorkPages);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ana Səhifə";
            FormClosing += HomePage_FormClosing;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)buttonGoOtherWorkPages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox buttonGoOtherWorkPages;
        private System.Windows.Forms.Button buttonGoParfumeBusinessPage;
        private System.Windows.Forms.Button button1;
    }
}