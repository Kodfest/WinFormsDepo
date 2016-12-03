using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10000saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            int gunlukSaat = Convert.ToInt32(SaatTxtB.Text);

            int gun = 10000 / gunlukSaat;
            int ay = gun / 30;
            int yil = ay / 12;

            MessageBox.Show("Yıl : " + yil + "\nAy : " + ay  + "\nGun : " + gun);
        }

        private void HesaplaBtn2_Click(object sender, EventArgs e)
        {
            int yas = int.Parse(YasTxtB.Text);
            int saat = int.Parse(YapilanSeyGunSaat.Text);

            double oran = ((double)saat / 24);


            MessageBox.Show((yas * oran) + " yıl yapmışsın");
        }
    }
}
