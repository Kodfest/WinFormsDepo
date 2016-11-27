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
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.AdSoyadTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SifreTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.BackgroundImage")));
            this.KaydetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KaydetBtn.Location = new System.Drawing.Point(142, 27);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(70, 63);
            this.KaydetBtn.TabIndex = 0;
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
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
            this.ClientSize = new System.Drawing.Size(224, 112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SifreTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdSoyadTxtB);
            this.Controls.Add(this.KaydetBtn);
            this.Name = "Form1";
            this.Text = "Merhaba Dünya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.TextBox AdSoyadTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SifreTxtB;
    }
}

