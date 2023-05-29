namespace MyBusiness.UI.Pages
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxLoginPassword = new System.Windows.Forms.TextBox();
            buttonLogin = new System.Windows.Forms.Button();
            textBoxLoginName = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(518, 476);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(54, 70, 93);
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(145, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 17);
            label2.TabIndex = 12;
            label2.Text = "Şifrəniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(54, 70, 93);
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(145, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 17);
            label1.TabIndex = 11;
            label1.Text = "Adınız:";
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxLoginPassword.Location = new System.Drawing.Point(145, 142);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.PasswordChar = '*';
            textBoxLoginPassword.Size = new System.Drawing.Size(215, 33);
            textBoxLoginPassword.TabIndex = 10;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = System.Drawing.Color.Black;
            buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonLogin.ForeColor = System.Drawing.Color.Yellow;
            buttonLogin.Location = new System.Drawing.Point(181, 192);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(152, 36);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Daxil ol";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLoginName
            // 
            textBoxLoginName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxLoginName.Location = new System.Drawing.Point(145, 69);
            textBoxLoginName.Name = "textBoxLoginName";
            textBoxLoginName.Size = new System.Drawing.Size(215, 33);
            textBoxLoginName.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.giphy;
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(518, 476);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(518, 476);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxLoginName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Giriş səhifəsi";
            FormClosing += LoginPage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}