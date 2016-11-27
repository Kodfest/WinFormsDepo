using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        List<double> hafiza = new List<double>();
        string islem;
        private void ButtonClick(object sender, EventArgs args)
        {
            Button button = sender as Button;

            if (button != null)
            {
                switch (button.Text)
                {
                    case "+":
                        if (Sonuc.Text != "")
                        {
                            hafiza.Add(Double.Parse(Sonuc.Text));
                            Sonuc.Text = "";
                        }
                        islem = "+";
                        break;

                    case "-":
                        if (Sonuc.Text != "")
                        {
                            hafiza.Add(Double.Parse(Sonuc.Text));
                            Sonuc.Text = "";
                        }
                        islem = "-";
                        break;

                    case "x":
                        if (Sonuc.Text != "")
                        {
                            hafiza.Add(Double.Parse(Sonuc.Text));
                            Sonuc.Text = "";
                        }
                        islem = "x";
                        break;

                    case "/":
                        if (Sonuc.Text != "")
                        {
                            hafiza.Add(Double.Parse(Sonuc.Text));
                            Sonuc.Text = "";
                        }
                        islem = "/";
                        break;

                    case "=":
                        hafiza.Add(Double.Parse(Sonuc.Text));
                        Sonuc.Text = hesapla(hafiza, Char.Parse(islem)).ToString();
                        islem = null;
                        hafiza.Clear();
                        break;

                    case "Temizle":
                        Sonuc.Text = "";
                        hafiza.Clear();
                        islem = null;
                        break;

                    default:
                        Sonuc.Text += button.Text;
                        break;
                }
            }
        }

        private double hesapla(List<double> list, char c)
        {
            double result = 0;

            if (c == '+')
            {
                double toplam = 0;
                foreach (var item in list)
                {
                    toplam += item;
                }
                result = toplam;
            }
            if (c == '-')
            {
                double fark = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    fark -= list[i];
                }
                result = fark;
            }
            if (c == '/')
            {
                double bolum = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    bolum /= list[i];
                }
                result = bolum;
            }
            if (c == 'x')
            {
                double carpim = 1;
                foreach (var item in list)
                {
                    carpim *= item;
                }
                result = carpim;
            }
            return result;
        }
    }
}
