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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonGoParfumeBusinessPage = new System.Windows.Forms.Button();
            buttonGoWebBusinessPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(800, 450);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonGoParfumeBusinessPage
            // 
            buttonGoParfumeBusinessPage.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonGoParfumeBusinessPage.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonGoParfumeBusinessPage.BackgroundImage");
            buttonGoParfumeBusinessPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoParfumeBusinessPage.ForeColor = System.Drawing.Color.Lime;
            buttonGoParfumeBusinessPage.Location = new System.Drawing.Point(30, 123);
            buttonGoParfumeBusinessPage.Name = "buttonGoParfumeBusinessPage";
            buttonGoParfumeBusinessPage.Size = new System.Drawing.Size(168, 46);
            buttonGoParfumeBusinessPage.TabIndex = 7;
            buttonGoParfumeBusinessPage.Text = "ƏTİR TİCARƏTİM";
            buttonGoParfumeBusinessPage.UseVisualStyleBackColor = false;
            buttonGoParfumeBusinessPage.Click += buttonGoParfumeBusinessPage_Click;
            buttonGoParfumeBusinessPage.MouseHover += buttonGoParfumeBusinessPage_MouseHover;
            // 
            // buttonGoWebBusinessPage
            // 
            buttonGoWebBusinessPage.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonGoWebBusinessPage.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonGoWebBusinessPage.BackgroundImage");
            buttonGoWebBusinessPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoWebBusinessPage.ForeColor = System.Drawing.Color.Lime;
            buttonGoWebBusinessPage.Location = new System.Drawing.Point(30, 224);
            buttonGoWebBusinessPage.Name = "buttonGoWebBusinessPage";
            buttonGoWebBusinessPage.Size = new System.Drawing.Size(168, 46);
            buttonGoWebBusinessPage.TabIndex = 8;
            buttonGoWebBusinessPage.Text = "İNTERNET İŞLƏRİM";
            buttonGoWebBusinessPage.UseVisualStyleBackColor = false;
            buttonGoWebBusinessPage.Click += buttonGoWebBusinessPage_Click;
            buttonGoWebBusinessPage.MouseHover += buttonGoWebBusinessPage_MouseHover;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonGoWebBusinessPage);
            Controls.Add(buttonGoParfumeBusinessPage);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ana Səhifə";
            FormClosing += HomePage_FormClosing;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGoParfumeBusinessPage;
        private System.Windows.Forms.Button buttonGoWebBusinessPage;
    }
}