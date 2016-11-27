using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int red, green, blue;
        
        private Color RasgeleRenkOlustur()
        {
            red = random.Next(0, 256);
            green = random.Next(0, 256);
            blue = random.Next(0, 256);

            Color rasgeleRenk = Color.FromArgb(red, green, blue);

            return rasgeleRenk;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form yüklenirken 20 tane buton oluşturuyoruz
            for (int i = 0; i < 20; i++)
            {
                // yeni bir buton oluşturuyoruz
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;

                // butonun arka plan rengine yazdığımız metod ile rasgele bir renk atıyoruz
                btn.BackColor = RasgeleRenkOlustur();

                // butona soldan boşluk bırakıyoruz
                btn.Left = (btn.Width * i);

                // Click eventi ortak metoda yönlediriyoruz
                btn.Click += Btn_Click;

                this.Controls.Add(btn);
            }
        }

        // Tüm butonlar için ortak click eventi için click metodu oluşturuyoruz
        private void Btn_Click(object sender, EventArgs e)
        {
            //Button secilenBtn = (Button)sender; 
            Button secilenBtn = sender as Button;
            this.BackColor = secilenBtn.BackColor;
        }
    }
}
