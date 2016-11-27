namespace HelloWorld
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MerhabaDunyaBtn = new System.Windows.Forms.Button();
            this.AdSoyadTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SifreTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MerhabaDunyaBtn
            // 
            this.MerhabaDunyaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MerhabaDunyaBtn.BackgroundImage")));
            this.MerhabaDunyaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MerhabaDunyaBtn.Location = new System.Drawing.Point(155, 60);
            this.MerhabaDunyaBtn.Name = "MerhabaDunyaBtn";
            this.MerhabaDunyaBtn.Size = new System.Drawing.Size(34, 30);
            this.MerhabaDunyaBtn.TabIndex = 0;
            this.MerhabaDunyaBtn.UseVisualStyleBackColor = true;
            this.MerhabaDunyaBtn.Click += new System.EventHandler(this.MerhabaDunyaBtn_Click);
            // 
            // AdSoyadTxtB
            // 
            this.AdSoyadTxtB.Location = new System.Drawing.Point(12, 27);
            this.AdSoyadTxtB.Name = "AdSoyadTxtB";
            this.AdSoyadTxtB.Size = new System.Drawing.Size(124, 20);
            this.AdSoyadTxtB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // SifreTxtB
            // 
            this.SifreTxtB.Location = new System.Drawing.Point(12, 70);
            this.SifreTxtB.Name = "SifreTxtB";
            this.SifreTxtB.Size = new System.Drawing.Size(124, 20);
            this.SifreTxtB.TabIndex = 3;
            this.SifreTxtB.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(212, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SifreTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdSoyadTxtB);
            this.Controls.Add(this.MerhabaDunyaBtn);
            this.Name = "Form1";
            this.Text = "Merhaba Dünya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MerhabaDunyaBtn;
        private System.Windows.Forms.TextBox AdSoyadTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SifreTxtB;
    }
}

