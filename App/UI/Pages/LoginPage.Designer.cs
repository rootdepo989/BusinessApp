namespace App.UI.Pages
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
            pictureBox2 = new System.Windows.Forms.PictureBox();
            textBoxADMİNNAME = new System.Windows.Forms.TextBox();
            textBoxADMİNPASSWORD = new System.Windows.Forms.TextBox();
            buttonLOGIN = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(280, 450);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBoxADMİNNAME
            // 
            textBoxADMİNNAME.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxADMİNNAME.Location = new System.Drawing.Point(59, 245);
            textBoxADMİNNAME.Name = "textBoxADMİNNAME";
            textBoxADMİNNAME.Size = new System.Drawing.Size(163, 23);
            textBoxADMİNNAME.TabIndex = 3;
            textBoxADMİNNAME.TextChanged += textBoxADMİNNAME_TextChanged;
            textBoxADMİNNAME.MouseDown += textBoxADMİNNAME_MouseDown;
            // 
            // textBoxADMİNPASSWORD
            // 
            textBoxADMİNPASSWORD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxADMİNPASSWORD.Location = new System.Drawing.Point(59, 309);
            textBoxADMİNPASSWORD.Name = "textBoxADMİNPASSWORD";
            textBoxADMİNPASSWORD.PasswordChar = '*';
            textBoxADMİNPASSWORD.Size = new System.Drawing.Size(163, 23);
            textBoxADMİNPASSWORD.TabIndex = 4;
            textBoxADMİNPASSWORD.MouseDown += textBoxADMİNPASSWORD_MouseDown;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonLOGIN.Location = new System.Drawing.Point(86, 361);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new System.Drawing.Size(108, 27);
            buttonLOGIN.TabIndex = 5;
            buttonLOGIN.Text = "Daxil ol";
            buttonLOGIN.UseVisualStyleBackColor = true;
            buttonLOGIN.Click += buttonLOGIN_Click;
            buttonLOGIN.MouseHover += buttonLOGIN_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.RoyalBlue;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(85, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 17);
            label1.TabIndex = 6;
            label1.Text = "Xoş Gəldin Rasim";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(280, 450);
            Controls.Add(label1);
            Controls.Add(buttonLOGIN);
            Controls.Add(textBoxADMİNPASSWORD);
            Controls.Add(textBoxADMİNNAME);
            Controls.Add(pictureBox2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Giriş Səhifəsi";
            FormClosing += LoginPage_FormClosing;
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxADMİNNAME;
        private System.Windows.Forms.TextBox textBoxADMİNPASSWORD;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.Label label1;
    }
}