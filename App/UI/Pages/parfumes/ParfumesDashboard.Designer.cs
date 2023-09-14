namespace App.UI.Pages
{
    partial class ParfumesDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParfumesDashboard));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonGoSalesPage = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            buttonGoSellersPage = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // buttonGoSalesPage
            // 
            buttonGoSalesPage.BackColor = System.Drawing.Color.Red;
            buttonGoSalesPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoSalesPage.ForeColor = System.Drawing.Color.White;
            buttonGoSalesPage.Location = new System.Drawing.Point(438, 233);
            buttonGoSalesPage.Name = "buttonGoSalesPage";
            buttonGoSalesPage.Size = new System.Drawing.Size(163, 35);
            buttonGoSalesPage.TabIndex = 8;
            buttonGoSalesPage.Text = "Satışlar";
            buttonGoSalesPage.UseVisualStyleBackColor = false;
            buttonGoSalesPage.MouseHover += buttonGoSalesPage_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(438, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(163, 87);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // buttonGoSellersPage
            // 
            buttonGoSellersPage.BackColor = System.Drawing.Color.Red;
            buttonGoSellersPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoSellersPage.ForeColor = System.Drawing.Color.White;
            buttonGoSellersPage.Location = new System.Drawing.Point(166, 233);
            buttonGoSellersPage.Name = "buttonGoSellersPage";
            buttonGoSellersPage.Size = new System.Drawing.Size(163, 35);
            buttonGoSellersPage.TabIndex = 6;
            buttonGoSellersPage.Text = "Satıcılar";
            buttonGoSellersPage.UseVisualStyleBackColor = false;
            buttonGoSellersPage.Click += buttonGoSellersPage_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(166, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(163, 87);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // ParfumesDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonGoSalesPage);
            Controls.Add(pictureBox2);
            Controls.Add(buttonGoSellersPage);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ParfumesDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ətir Ticarəti Səhifəsi";
            FormClosing += ParfumesDashboard_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGoSalesPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonGoSellersPage;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}