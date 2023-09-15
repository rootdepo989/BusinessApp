namespace App.UI.Pages.Internet
{
    partial class InternetDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetDashboard));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBoxInInternetDashPage = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            buttonGoElanAtlasiPage = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInInternetDashPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(800, 450);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxInInternetDashPage
            // 
            pictureBoxInInternetDashPage.Image = (System.Drawing.Image)resources.GetObject("pictureBoxInInternetDashPage.Image");
            pictureBoxInInternetDashPage.Location = new System.Drawing.Point(331, 0);
            pictureBoxInInternetDashPage.Name = "pictureBoxInInternetDashPage";
            pictureBoxInInternetDashPage.Size = new System.Drawing.Size(469, 450);
            pictureBoxInInternetDashPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxInInternetDashPage.TabIndex = 1;
            pictureBoxInInternetDashPage.TabStop = false;
            pictureBoxInInternetDashPage.MouseHover += pictureBoxInInternetDashPage_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(358, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(125, 117);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // buttonGoElanAtlasiPage
            // 
            buttonGoElanAtlasiPage.BackColor = System.Drawing.Color.Black;
            buttonGoElanAtlasiPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoElanAtlasiPage.ForeColor = System.Drawing.Color.White;
            buttonGoElanAtlasiPage.Location = new System.Drawing.Point(358, 146);
            buttonGoElanAtlasiPage.Name = "buttonGoElanAtlasiPage";
            buttonGoElanAtlasiPage.Size = new System.Drawing.Size(125, 32);
            buttonGoElanAtlasiPage.TabIndex = 3;
            buttonGoElanAtlasiPage.Text = "Elan Atlası Səhifəsi";
            buttonGoElanAtlasiPage.UseVisualStyleBackColor = false;
            buttonGoElanAtlasiPage.Click += buttonGoElanAtlasiPage_Click;
            buttonGoElanAtlasiPage.MouseLeave += buttonGoElanAtlasiPage_MouseLeave;
            buttonGoElanAtlasiPage.MouseHover += buttonGoElanAtlasiPage_MouseHover;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(0, 427);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "<<<< Geri ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InternetDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonGoElanAtlasiPage);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBoxInInternetDashPage);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "InternetDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "İnternet İşlərim";
            FormClosing += InternetDashboard_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInInternetDashPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxInInternetDashPage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonGoElanAtlasiPage;
        private System.Windows.Forms.Button button1;
    }
}