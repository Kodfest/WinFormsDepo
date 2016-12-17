namespace SeckinTruzim
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTravego = new System.Windows.Forms.Panel();
            this.PanelNeoplan = new System.Windows.Forms.Panel();
            this.GBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.LabelOtobusTuru = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelKoltukNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBoxMusteriCinsiyet = new System.Windows.Forms.GroupBox();
            this.RadioBtnErkek = new System.Windows.Forms.RadioButton();
            this.RadioBtnKadin = new System.Windows.Forms.RadioButton();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtMusteriAdSoyAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBoxMusteriBilgileri.SuspendLayout();
            this.GBoxMusteriCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Neoplan"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(12, 181);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(256, 28);
            this.CBoxOtobusTuru.TabIndex = 1;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Türü:";
            // 
            // PanelTravego
            // 
            this.PanelTravego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTravego.Location = new System.Drawing.Point(291, 12);
            this.PanelTravego.Name = "PanelTravego";
            this.PanelTravego.Size = new System.Drawing.Size(155, 365);
            this.PanelTravego.TabIndex = 3;
            // 
            // PanelNeoplan
            // 
            this.PanelNeoplan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelNeoplan.Location = new System.Drawing.Point(290, 13);
            this.PanelNeoplan.Name = "PanelNeoplan";
            this.PanelNeoplan.Size = new System.Drawing.Size(155, 425);
            this.PanelNeoplan.TabIndex = 4;
            // 
            // GBoxMusteriBilgileri
            // 
            this.GBoxMusteriBilgileri.Controls.Add(this.LabelOtobusTuru);
            this.GBoxMusteriBilgileri.Controls.Add(this.label5);
            this.GBoxMusteriBilgileri.Controls.Add(this.LabelKoltukNo);
            this.GBoxMusteriBilgileri.Controls.Add(this.label3);
            this.GBoxMusteriBilgileri.Controls.Add(this.GBoxMusteriCinsiyet);
            this.GBoxMusteriBilgileri.Controls.Add(this.BtnKaydet);
            this.GBoxMusteriBilgileri.Controls.Add(this.TxtMusteriAdSoyAd);
            this.GBoxMusteriBilgileri.Controls.Add(this.label2);
            this.GBoxMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBoxMusteriBilgileri.Location = new System.Drawing.Point(465, 13);
            this.GBoxMusteriBilgileri.Name = "GBoxMusteriBilgileri";
            this.GBoxMusteriBilgileri.Size = new System.Drawing.Size(259, 234);
            this.GBoxMusteriBilgileri.TabIndex = 5;
            this.GBoxMusteriBilgileri.TabStop = false;
            this.GBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // LabelOtobusTuru
            // 
            this.LabelOtobusTuru.AutoSize = true;
            this.LabelOtobusTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelOtobusTuru.Location = new System.Drawing.Point(129, 168);
            this.LabelOtobusTuru.Name = "LabelOtobusTuru";
            this.LabelOtobusTuru.Size = new System.Drawing.Size(13, 17);
            this.LabelOtobusTuru.TabIndex = 7;
            this.LabelOtobusTuru.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Otobüs Türü :";
            // 
            // LabelKoltukNo
            // 
            this.LabelKoltukNo.AutoSize = true;
            this.LabelKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelKoltukNo.Location = new System.Drawing.Point(110, 145);
            this.LabelKoltukNo.Name = "LabelKoltukNo";
            this.LabelKoltukNo.Size = new System.Drawing.Size(16, 17);
            this.LabelKoltukNo.TabIndex = 5;
            this.LabelKoltukNo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koltuk No :";
            // 
            // GBoxMusteriCinsiyet
            // 
            this.GBoxMusteriCinsiyet.Controls.Add(this.RadioBtnErkek);
            this.GBoxMusteriCinsiyet.Controls.Add(this.RadioBtnKadin);
            this.GBoxMusteriCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBoxMusteriCinsiyet.Location = new System.Drawing.Point(17, 69);
            this.GBoxMusteriCinsiyet.Name = "GBoxMusteriCinsiyet";
            this.GBoxMusteriCinsiyet.Size = new System.Drawing.Size(236, 68);
            this.GBoxMusteriCinsiyet.TabIndex = 3;
            this.GBoxMusteriCinsiyet.TabStop = false;
            this.GBoxMusteriCinsiyet.Text = "Cinsiyet";
            // 
            // RadioBtnErkek
            // 
            this.RadioBtnErkek.AutoSize = true;
            this.RadioBtnErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioBtnErkek.Location = new System.Drawing.Point(7, 41);
            this.RadioBtnErkek.Name = "RadioBtnErkek";
            this.RadioBtnErkek.Size = new System.Drawing.Size(62, 21);
            this.RadioBtnErkek.TabIndex = 1;
            this.RadioBtnErkek.TabStop = true;
            this.RadioBtnErkek.Text = "Erkek";
            this.RadioBtnErkek.UseVisualStyleBackColor = true;
            // 
            // RadioBtnKadin
            // 
            this.RadioBtnKadin.AutoSize = true;
            this.RadioBtnKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioBtnKadin.Location = new System.Drawing.Point(7, 18);
            this.RadioBtnKadin.Name = "RadioBtnKadin";
            this.RadioBtnKadin.Size = new System.Drawing.Size(62, 21);
            this.RadioBtnKadin.TabIndex = 0;
            this.RadioBtnKadin.TabStop = true;
            this.RadioBtnKadin.Text = "Kadın";
            this.RadioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnKaydet.ForeColor = System.Drawing.Color.White;
            this.BtnKaydet.Location = new System.Drawing.Point(17, 193);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(236, 35);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtMusteriAdSoyAd
            // 
            this.TxtMusteriAdSoyAd.Location = new System.Drawing.Point(102, 29);
            this.TxtMusteriAdSoyAd.Name = "TxtMusteriAdSoyAd";
            this.TxtMusteriAdSoyAd.Size = new System.Drawing.Size(151, 26);
            this.TxtMusteriAdSoyAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 476);
            this.Controls.Add(this.GBoxMusteriBilgileri);
            this.Controls.Add(this.PanelNeoplan);
            this.Controls.Add(this.PanelTravego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBoxMusteriBilgileri.ResumeLayout(false);
            this.GBoxMusteriBilgileri.PerformLayout();
            this.GBoxMusteriCinsiyet.ResumeLayout(false);
            this.GBoxMusteriCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTravego;
        private System.Windows.Forms.Panel PanelNeoplan;
        private System.Windows.Forms.GroupBox GBoxMusteriBilgileri;
        private System.Windows.Forms.Label LabelOtobusTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelKoltukNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBoxMusteriCinsiyet;
        private System.Windows.Forms.RadioButton RadioBtnErkek;
        private System.Windows.Forms.RadioButton RadioBtnKadin;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtMusteriAdSoyAd;
        private System.Windows.Forms.Label label2;
    }
}

