namespace UzayYolu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SpaceShip = new System.Windows.Forms.PictureBox();
            this.bomba = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("SpaceShip.Image")));
            this.SpaceShip.Location = new System.Drawing.Point(12, 12);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(113, 70);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // bomba
            // 
            this.bomba.Image = ((System.Drawing.Image)(resources.GetObject("bomba.Image")));
            this.bomba.Location = new System.Drawing.Point(12, 156);
            this.bomba.Name = "bomba";
            this.bomba.Size = new System.Drawing.Size(33, 27);
            this.bomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomba.TabIndex = 1;
            this.bomba.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 257);
            this.Controls.Add(this.bomba);
            this.Controls.Add(this.SpaceShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.PictureBox bomba;
        private System.Windows.Forms.Timer timer1;
    }
}

