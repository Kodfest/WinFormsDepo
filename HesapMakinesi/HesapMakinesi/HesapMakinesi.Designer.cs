namespace HesapMakinesi
{
    partial class HesapMakinesi
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
            this.Sonuc = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.esittir = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sonuc
            // 
            this.Sonuc.Location = new System.Drawing.Point(12, 12);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(208, 20);
            this.Sonuc.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.AllowDrop = true;
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(12, 143);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(208, 26);
            this.clear.TabIndex = 33;
            this.clear.Text = "Temizle";
            this.clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num0
            // 
            this.num0.AllowDrop = true;
            this.num0.Location = new System.Drawing.Point(51, 108);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(33, 29);
            this.num0.TabIndex = 32;
            this.num0.Text = "0";
            this.num0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // esittir
            // 
            this.esittir.AllowDrop = true;
            this.esittir.Location = new System.Drawing.Point(12, 108);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(33, 29);
            this.esittir.TabIndex = 31;
            this.esittir.Text = "=";
            this.esittir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.esittir.UseVisualStyleBackColor = true;
            this.esittir.Click += new System.EventHandler(this.ButtonClick);
            // 
            // bolme
            // 
            this.bolme.AllowDrop = true;
            this.bolme.Location = new System.Drawing.Point(51, 73);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(33, 29);
            this.bolme.TabIndex = 30;
            this.bolme.Text = "/";
            this.bolme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.ButtonClick);
            // 
            // carp
            // 
            this.carp.AllowDrop = true;
            this.carp.Location = new System.Drawing.Point(12, 73);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(33, 29);
            this.carp.TabIndex = 29;
            this.carp.Text = "x";
            this.carp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Click += new System.EventHandler(this.ButtonClick);
            // 
            // cikar
            // 
            this.cikar.AllowDrop = true;
            this.cikar.Location = new System.Drawing.Point(51, 38);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(33, 29);
            this.cikar.TabIndex = 28;
            this.cikar.Text = "-";
            this.cikar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.Click += new System.EventHandler(this.ButtonClick);
            // 
            // topla
            // 
            this.topla.AllowDrop = true;
            this.topla.Location = new System.Drawing.Point(12, 38);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(33, 29);
            this.topla.TabIndex = 27;
            this.topla.Text = "+";
            this.topla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(180, 108);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(40, 29);
            this.num9.TabIndex = 26;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(134, 108);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(40, 29);
            this.num8.TabIndex = 25;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(88, 108);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(40, 29);
            this.num7.TabIndex = 24;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(180, 73);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(40, 29);
            this.num6.TabIndex = 23;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(134, 73);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(40, 29);
            this.num5.TabIndex = 22;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(88, 73);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(40, 29);
            this.num4.TabIndex = 21;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(180, 38);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(40, 29);
            this.num3.TabIndex = 20;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(134, 38);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(40, 29);
            this.num2.TabIndex = 19;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(88, 38);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(40, 29);
            this.num1.TabIndex = 18;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 180);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Sonuc);
            this.Name = "HesapMakinesi";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button esittir;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.TextBox Sonuc;
    }
}

