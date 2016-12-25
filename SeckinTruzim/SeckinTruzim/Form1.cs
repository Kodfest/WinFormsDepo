using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeckinTruzim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("Photos/pt_logo.png");

            this.BackColor = Color.FromArgb(255, 255, 255);

            PanelTravego.Visible = false;
            PanelNeoplan.Visible = false;

            GBoxMusteriBilgileri.Enabled = false;

            #region TavegoKoltuklari
            byte counter = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 11) && (i != 5 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += ButtonClick;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + ""; //counter.ToString();
                        btn.BackColor = RenkOlustur(counter, "Travego");
                        btn.ForeColor = Color.White;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Height * i;
                        PanelTravego.Controls.Add(btn);
                        counter++;
                    }
                }
            }
            #endregion

            #region NeoplanKoltuklari
            counter = 1;
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 13) && (i != 6 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += ButtonClick;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + ""; //counter.ToString();
                        btn.BackColor = RenkOlustur(counter, "Neoplan");
                        btn.ForeColor = Color.White;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Height * i;
                        PanelNeoplan.Controls.Add(btn);
                        counter++;
                    }
                }
            }
            #endregion
            
        }
        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtMusteriAdSoyAd.Clear(); // TxtMusteriAdSoyAd.Text = "";
            RadioBtnErkek.Checked = false;
            RadioBtnKadin.Checked = false;

            if (CBoxOtobusTuru.SelectedItem.ToString() == "Neoplan")
            {
                PanelNeoplan.Visible = true;
                PanelTravego.Visible = false;
            }
            else if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                PanelTravego.Visible = true;
                PanelNeoplan.Visible = false;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {

            Button secilenKoltuk = sender as Button;
            LabelKoltukNo.Text = secilenKoltuk.Text;
            LabelOtobusTuru.Text = CBoxOtobusTuru.SelectedItem.ToString();

            GBoxMusteriBilgileri.Enabled = true;

            if (musteriler.Count != 0)
            {
                Musteri secilenMusteri = musteriler[int.Parse(secilenKoltuk.Text) - 1];

                if (secilenMusteri.adi != null)
                {
                    TxtMusteriAdSoyAd.Text = secilenMusteri.adi;
                    string cinsiyet = secilenMusteri.cinsiyet;

                    RadioBtnErkek.Checked = cinsiyet == "Erkek" ? true : false;
                    RadioBtnKadin.Checked = cinsiyet == "Kadın" ? true : false;

                    LabelKoltukNo.Text = secilenMusteri.koltukNo.ToString();
                    LabelOtobusTuru.Text = secilenMusteri.otobusTuru.ToString();

                    string oncekiVeyaSonrakiCinsiyet;

                    if (secilenMusteri.koltukNo % 2 == 0)
                    {
                        int bakilacakKoltuk = secilenMusteri.koltukNo - 1;

                        oncekiVeyaSonrakiCinsiyet = musteriler[bakilacakKoltuk - 1].cinsiyet;

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RadioBtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RadioBtnErkek.Enabled = false;
                        }
                        else
                        {
                            RadioBtnErkek.Enabled = true;
                            RadioBtnKadin.Enabled = true;
                        }
                    }
                    else
                    {
                        int bakilacakKoltuk = secilenMusteri.koltukNo + 1;

                        oncekiVeyaSonrakiCinsiyet = musteriler[bakilacakKoltuk - 1].cinsiyet;

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RadioBtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RadioBtnErkek.Enabled = false;
                        }
                        else
                        {
                            RadioBtnErkek.Enabled = true;
                            RadioBtnKadin.Enabled = true;
                        }
                    }
                }
            }
        }

        List<Musteri> musteriler = new List<Musteri>();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.adi = TxtMusteriAdSoyAd.Text;

            string cinsiyet = RadioBtnErkek.Checked == true ? "Erkek" : "Kadın";
            musteri.cinsiyet = cinsiyet;

            musteri.koltukNo = Byte.Parse(LabelKoltukNo.Text);
            musteri.otobusTuru = LabelOtobusTuru.Text;
            musteriler.Add(musteri);

            PanelNeoplan.Controls.Clear();
            PanelTravego.Controls.Clear();

            Form1_Load(sender, e);

            CBoxOtobusTuru.SelectedItem = LabelOtobusTuru.Text;
            CBoxOtobusTuru_SelectedIndexChanged(sender, e);

            TxtMusteriAdSoyAd.Clear();
            LabelKoltukNo.Text = "";
            LabelOtobusTuru.Text = "";
        }

        private Color RenkOlustur(int count, string otobusTuru)
        {
            Color color = Color.FromArgb(1, 22, 64);

            if (musteriler.Count != 0)
            {
                if (musteriler[count - 1] != null)
                {
                    string cinsiyet = musteriler[count - 1].cinsiyet;

                    if (cinsiyet == "Erkek")
                    {
                        color = Color.Blue;
                    }
                    else if (cinsiyet == "Kadın")
                    {
                        color = Color.Pink;
                    }
                    else
                    {
                        color = Color.FromArgb(1, 22, 64);
                    }
                }
            }
            
            return color;
        }
    }
}
