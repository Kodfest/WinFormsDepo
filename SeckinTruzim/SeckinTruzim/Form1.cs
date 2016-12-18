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
            
            #region Kullanıcı_Bilgilerini_Getir
            if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                string yolcu = travegoYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];

                if (yolcu != "")
                {
                    TxtMusteriAdSoyAd.Text = yolcu;
                    
                    #region ÖncekiKoltukDurumu
                    string oncekiVeyaSonrakiCinsiyet;
                    int KoltukNo = int.Parse(LabelKoltukNo.Text);
                    if (KoltukNo % 2 == 0)
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) - 1;

                        oncekiVeyaSonrakiCinsiyet = travegoYolcularCinsiyet[bakilacakKoltuk - 1];

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
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) + 1;

                        oncekiVeyaSonrakiCinsiyet = travegoYolcularCinsiyet[bakilacakKoltuk-1];

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
                    #endregion

                    #region CinsiyeteGöreGörünümAyarlama
                    string kendiCinsiyeti = travegoYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];
                    if (kendiCinsiyeti == "Erkek")
                    {
                        RadioBtnErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }
                    else if (kendiCinsiyeti == "Kadın")
                    {
                        RadioBtnKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Pink;
                    }
                    #endregion

                }
            }
            else
            {
                string yolcu = neoplanYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];

                if (yolcu != "")
                {
                    TxtMusteriAdSoyAd.Text = yolcu;

                    #region ÖncekiKoltukDurumu
                    string oncekiVeyaSonrakiCinsiyet;
                    int KoltukNo = int.Parse(LabelKoltukNo.Text);
                    if (KoltukNo % 2 == 0)
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) - 1;

                        oncekiVeyaSonrakiCinsiyet = neoplanYolcularCinsiyet[bakilacakKoltuk];

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RadioBtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RadioBtnErkek.Enabled = false;
                        }
                    }
                    else
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) + 1;

                        oncekiVeyaSonrakiCinsiyet = neoplanYolcularCinsiyet[bakilacakKoltuk];

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RadioBtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RadioBtnErkek.Enabled = false;
                        }
                    }
                    #endregion

                    #region CinsiyeteGöreGörünümAyarlama
                    string cinsiyet = neoplanYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];
                    if (cinsiyet == "Erkek")
                    {
                        RadioBtnErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }
                    else if (cinsiyet == "Kadın")
                    {
                        RadioBtnKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Pink;
                    }
                    #endregion
                }
            }
            #endregion
            
        }

        string[] travegoYolcularIsim = new string[47];
        string[] travegoYolcularCinsiyet = new string[47];
        string[] neoplanYolcularIsim = new string[55];
        string[] neoplanYolcularCinsiyet = new string[55];
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            #region Kaydet
            if (LabelOtobusTuru.Text == "Neoplan")
            {
                neoplanYolcularIsim[int.Parse(LabelKoltukNo.Text) - 1] = TxtMusteriAdSoyAd.Text;

                string cinsiyet;

                if (RadioBtnKadin.Checked)
                {
                    cinsiyet = "Kadın";
                }
                else
                {
                    cinsiyet = "Erkek";
                }

                neoplanYolcularCinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
                
            }
            else
            {
                travegoYolcularIsim[int.Parse(LabelKoltukNo.Text) - 1] = TxtMusteriAdSoyAd.Text;

                string cinsiyet;

                if (RadioBtnKadin.Checked)
                {
                    cinsiyet = "Kadın";
                }
                else
                {
                    cinsiyet = "Erkek";
                }

                travegoYolcularCinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
            #endregion
            

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
            Color color;
            if(otobusTuru == "Travego")
            {
                string cinsiyet = travegoYolcularCinsiyet[count - 1];
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
            else
            {
                string cinsiyet = neoplanYolcularCinsiyet[count - 1];
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
            return color;
        }
    }
}
