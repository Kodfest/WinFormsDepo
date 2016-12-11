namespace FormControls
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tarayici = new System.Windows.Forms.WebBrowser();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.BtnGit = new System.Windows.Forms.Button();
            this.Takvim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYas = new System.Windows.Forms.TextBox();
            this.BtnYukle = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.PicBox);
            this.groupBox1.Controls.Add(this.BtnYukle);
            this.groupBox1.Controls.Add(this.TxtYas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Takvim);
            this.groupBox1.Controls.Add(this.BtnGit);
            this.groupBox1.Controls.Add(this.TxtURL);
            this.groupBox1.Controls.Add(this.Tarayici);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Kontrolleri";
            // 
            // Tarayici
            // 
            this.Tarayici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tarayici.Location = new System.Drawing.Point(6, 45);
            this.Tarayici.MinimumSize = new System.Drawing.Size(20, 20);
            this.Tarayici.Name = "Tarayici";
            this.Tarayici.Size = new System.Drawing.Size(323, 245);
            this.Tarayici.TabIndex = 0;
            // 
            // TxtURL
            // 
            this.TxtURL.Location = new System.Drawing.Point(6, 19);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(261, 20);
            this.TxtURL.TabIndex = 1;
            // 
            // BtnGit
            // 
            this.BtnGit.Location = new System.Drawing.Point(273, 18);
            this.BtnGit.Name = "BtnGit";
            this.BtnGit.Size = new System.Drawing.Size(56, 23);
            this.BtnGit.TabIndex = 2;
            this.BtnGit.Text = "Git";
            this.BtnGit.UseVisualStyleBackColor = true;
            this.BtnGit.Click += new System.EventHandler(this.BtnGit_Click);
            // 
            // Takvim
            // 
            this.Takvim.Location = new System.Drawing.Point(431, 19);
            this.Takvim.Name = "Takvim";
            this.Takvim.Size = new System.Drawing.Size(200, 20);
            this.Takvim.TabIndex = 3;
            this.Takvim.ValueChanged += new System.EventHandler(this.Takvim_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yaş";
            // 
            // TxtYas
            // 
            this.TxtYas.Location = new System.Drawing.Point(431, 42);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.ReadOnly = true;
            this.TxtYas.Size = new System.Drawing.Size(200, 20);
            this.TxtYas.TabIndex = 6;
            // 
            // BtnYukle
            // 
            this.BtnYukle.Location = new System.Drawing.Point(358, 82);
            this.BtnYukle.Name = "BtnYukle";
            this.BtnYukle.Size = new System.Drawing.Size(75, 23);
            this.BtnYukle.TabIndex = 7;
            this.BtnYukle.Text = "Yükle";
            this.BtnYukle.UseVisualStyleBackColor = true;
            this.BtnYukle.Click += new System.EventHandler(this.BtnYukle_Click);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(439, 82);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(192, 140);
            this.PicBox.TabIndex = 8;
            this.PicBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(651, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 100);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 320);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGit;
        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.WebBrowser Tarayici;
        private System.Windows.Forms.DateTimePicker Takvim;
        private System.Windows.Forms.TextBox TxtYas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button BtnYukle;
        private System.Windows.Forms.Panel panel1;
    }
}

