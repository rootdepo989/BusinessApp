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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            textBoxADMİNNAME = new System.Windows.Forms.TextBox();
            textBoxADMİNPASSWORD = new System.Windows.Forms.TextBox();
            buttonLOGIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(480, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(206, 320);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(22, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(369, 409);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(510, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 24);
            label1.TabIndex = 2;
            label1.Text = "Xoş Gəldin Rasim!";
            label1.Click += label1_Click;
            // 
            // textBoxADMİNNAME
            // 
            textBoxADMİNNAME.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxADMİNNAME.Location = new System.Drawing.Point(83, 152);
            textBoxADMİNNAME.Name = "textBoxADMİNNAME";
            textBoxADMİNNAME.Size = new System.Drawing.Size(245, 35);
            textBoxADMİNNAME.TabIndex = 3;
            // 
            // textBoxADMİNPASSWORD
            // 
            textBoxADMİNPASSWORD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxADMİNPASSWORD.Location = new System.Drawing.Point(83, 229);
            textBoxADMİNPASSWORD.Name = "textBoxADMİNPASSWORD";
            textBoxADMİNPASSWORD.PasswordChar = '*';
            textBoxADMİNPASSWORD.Size = new System.Drawing.Size(245, 35);
            textBoxADMİNPASSWORD.TabIndex = 4;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonLOGIN.Location = new System.Drawing.Point(117, 320);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new System.Drawing.Size(184, 33);
            buttonLOGIN.TabIndex = 5;
            buttonLOGIN.Text = "Daxil ol";
            buttonLOGIN.UseVisualStyleBackColor = true;
            buttonLOGIN.Click += buttonLOGIN_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(763, 450);
            Controls.Add(buttonLOGIN);
            Controls.Add(textBoxADMİNPASSWORD);
            Controls.Add(textBoxADMİNNAME);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Giriş Səhifəsi";
            FormClosing += LoginPage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxADMİNNAME;
        private System.Windows.Forms.TextBox textBoxADMİNPASSWORD;
        private System.Windows.Forms.Button buttonLOGIN;
    }
}