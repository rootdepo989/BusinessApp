namespace MyBusiness.UI.Pages
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
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonGoSellersPage = new System.Windows.Forms.Button();
            buttonGoSalesPage = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            buttonGoWaitingManeyPage = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(348, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Ana səhifə";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_690855708_612x612;
            pictureBox1.Location = new System.Drawing.Point(60, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 87);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonGoSellersPage
            // 
            buttonGoSellersPage.BackColor = System.Drawing.Color.Red;
            buttonGoSellersPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoSellersPage.ForeColor = System.Drawing.Color.White;
            buttonGoSellersPage.Location = new System.Drawing.Point(60, 236);
            buttonGoSellersPage.Name = "buttonGoSellersPage";
            buttonGoSellersPage.Size = new System.Drawing.Size(144, 35);
            buttonGoSellersPage.TabIndex = 2;
            buttonGoSellersPage.Text = "Satıcılar";
            buttonGoSellersPage.UseVisualStyleBackColor = false;
            buttonGoSellersPage.Click += buttonGoSellersPage_Click;
            // 
            // buttonGoSalesPage
            // 
            buttonGoSalesPage.BackColor = System.Drawing.Color.Red;
            buttonGoSalesPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoSalesPage.ForeColor = System.Drawing.Color.White;
            buttonGoSalesPage.Location = new System.Drawing.Point(336, 236);
            buttonGoSalesPage.Name = "buttonGoSalesPage";
            buttonGoSalesPage.Size = new System.Drawing.Size(144, 35);
            buttonGoSalesPage.TabIndex = 4;
            buttonGoSalesPage.Text = "Satışlar";
            buttonGoSalesPage.UseVisualStyleBackColor = false;
            buttonGoSalesPage.Click += buttonGoSalesPage_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(336, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(144, 87);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // buttonGoWaitingManeyPage
            // 
            buttonGoWaitingManeyPage.BackColor = System.Drawing.Color.Red;
            buttonGoWaitingManeyPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonGoWaitingManeyPage.ForeColor = System.Drawing.Color.White;
            buttonGoWaitingManeyPage.Location = new System.Drawing.Point(601, 236);
            buttonGoWaitingManeyPage.Name = "buttonGoWaitingManeyPage";
            buttonGoWaitingManeyPage.Size = new System.Drawing.Size(144, 35);
            buttonGoWaitingManeyPage.TabIndex = 6;
            buttonGoWaitingManeyPage.Text = "Nisyələr";
            buttonGoWaitingManeyPage.UseVisualStyleBackColor = false;
            buttonGoWaitingManeyPage.Click += buttonGoWaitingManeyPage_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(601, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(144, 87);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonGoWaitingManeyPage);
            Controls.Add(pictureBox3);
            Controls.Add(buttonGoSalesPage);
            Controls.Add(pictureBox2);
            Controls.Add(buttonGoSellersPage);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ana səhifə";
            FormClosing += HomePage_FormClosing;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGoSellersPage;
        private System.Windows.Forms.Button buttonGoSalesPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonGoWaitingManeyPage;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}