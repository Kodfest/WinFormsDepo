namespace _10000saat
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
            this.SaatTxtB = new System.Windows.Forms.TextBox();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YasTxtB = new System.Windows.Forms.TextBox();
            this.YapilanSeyGunSaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HesaplaBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaatTxtB
            // 
            this.SaatTxtB.Location = new System.Drawing.Point(12, 43);
            this.SaatTxtB.Name = "SaatTxtB";
            this.SaatTxtB.Size = new System.Drawing.Size(151, 20);
            this.SaatTxtB.TabIndex = 0;
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Location = new System.Drawing.Point(12, 69);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(151, 23);
            this.hesaplaBtn.TabIndex = 1;
            this.hesaplaBtn.Text = "Hesapla";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.hesaplaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Günde Kaç Saat Çalışacaksın?";
            // 
            // YasTxtB
            // 
            this.YasTxtB.Location = new System.Drawing.Point(341, 24);
            this.YasTxtB.Name = "YasTxtB";
            this.YasTxtB.Size = new System.Drawing.Size(100, 20);
            this.YasTxtB.TabIndex = 3;
            // 
            // YapilanSeyGunSaat
            // 
            this.YapilanSeyGunSaat.Location = new System.Drawing.Point(341, 50);
            this.YapilanSeyGunSaat.Name = "YapilanSeyGunSaat";
            this.YapilanSeyGunSaat.Size = new System.Drawing.Size(100, 20);
            this.YapilanSeyGunSaat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaç Yaşındasın?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Günde Kaç Saat ?";
            // 
            // HesaplaBtn2
            // 
            this.HesaplaBtn2.Location = new System.Drawing.Point(341, 76);
            this.HesaplaBtn2.Name = "HesaplaBtn2";
            this.HesaplaBtn2.Size = new System.Drawing.Size(100, 23);
            this.HesaplaBtn2.TabIndex = 7;
            this.HesaplaBtn2.Text = "Hesapla";
            this.HesaplaBtn2.UseVisualStyleBackColor = true;
            this.HesaplaBtn2.Click += new System.EventHandler(this.HesaplaBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 119);
            this.Controls.Add(this.HesaplaBtn2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YapilanSeyGunSaat);
            this.Controls.Add(this.YasTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplaBtn);
            this.Controls.Add(this.SaatTxtB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SaatTxtB;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YasTxtB;
        private System.Windows.Forms.TextBox YapilanSeyGunSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HesaplaBtn2;
    }
}

