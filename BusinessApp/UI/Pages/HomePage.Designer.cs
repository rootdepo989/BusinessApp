namespace BusinessApp.UI.Pages
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            buttonGoSellersPage = new System.Windows.Forms.Button();
            buttonGoSalesPage = new System.Windows.Forms.Button();
            buttonGoCreditsPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(800, 450);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(349, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "Ana səhifə";
            // 
            // buttonGoSellersPage
            // 
            buttonGoSellersPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoSellersPage.Location = new System.Drawing.Point(96, 206);
            buttonGoSellersPage.Name = "buttonGoSellersPage";
            buttonGoSellersPage.Size = new System.Drawing.Size(139, 39);
            buttonGoSellersPage.TabIndex = 2;
            buttonGoSellersPage.Text = "Satıcılar";
            buttonGoSellersPage.UseVisualStyleBackColor = true;
            buttonGoSellersPage.Click += buttonGoSellersPage_Click;
            // 
            // buttonGoSalesPage
            // 
            buttonGoSalesPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoSalesPage.Location = new System.Drawing.Point(330, 206);
            buttonGoSalesPage.Name = "buttonGoSalesPage";
            buttonGoSalesPage.Size = new System.Drawing.Size(139, 39);
            buttonGoSalesPage.TabIndex = 3;
            buttonGoSalesPage.Text = "Satışlar";
            buttonGoSalesPage.UseVisualStyleBackColor = true;
            buttonGoSalesPage.Click += buttonGoSalesPage_Click;
            // 
            // buttonGoCreditsPage
            // 
            buttonGoCreditsPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoCreditsPage.Location = new System.Drawing.Point(567, 206);
            buttonGoCreditsPage.Name = "buttonGoCreditsPage";
            buttonGoCreditsPage.Size = new System.Drawing.Size(139, 39);
            buttonGoCreditsPage.TabIndex = 4;
            buttonGoCreditsPage.Text = "Nisyələr";
            buttonGoCreditsPage.UseVisualStyleBackColor = true;
            buttonGoCreditsPage.Click += buttonGoCreditsPage_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonGoCreditsPage);
            Controls.Add(buttonGoSalesPage);
            Controls.Add(buttonGoSellersPage);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ana səhifə";
            FormClosing += HomePage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoSellersPage;
        private System.Windows.Forms.Button buttonGoSalesPage;
        private System.Windows.Forms.Button buttonGoCreditsPage;
    }
}