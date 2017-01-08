namespace GunlukKurXML
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
            this.BtnGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGridKurlar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBoxKurTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGridKurlar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetir
            // 
            this.BtnGetir.Location = new System.Drawing.Point(9, 40);
            this.BtnGetir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(121, 28);
            this.BtnGetir.TabIndex = 0;
            this.BtnGetir.Text = "GETİR";
            this.BtnGetir.UseVisualStyleBackColor = true;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // DGridKurlar
            // 
            this.DGridKurlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridKurlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGridKurlar.Location = new System.Drawing.Point(140, 32);
            this.DGridKurlar.Margin = new System.Windows.Forms.Padding(4);
            this.DGridKurlar.Name = "DGridKurlar";
            this.DGridKurlar.Size = new System.Drawing.Size(244, 148);
            this.DGridKurlar.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Para Birimi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kur Değeri";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // CBoxKurTuru
            // 
            this.CBoxKurTuru.FormattingEnabled = true;
            this.CBoxKurTuru.Location = new System.Drawing.Point(9, 9);
            this.CBoxKurTuru.Name = "CBoxKurTuru";
            this.CBoxKurTuru.Size = new System.Drawing.Size(121, 24);
            this.CBoxKurTuru.TabIndex = 3;
            this.CBoxKurTuru.SelectedIndexChanged += new System.EventHandler(this.CboxSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 190);
            this.Controls.Add(this.CBoxKurTuru);
            this.Controls.Add(this.DGridKurlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGetir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridKurlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGridKurlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox CBoxKurTuru;
    }
}

