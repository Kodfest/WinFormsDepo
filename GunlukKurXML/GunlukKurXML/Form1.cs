using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GunlukKurXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //http://www.tcmb.gov.tr/kurlar/201612/01122016.xml

        bool dolarState = false, euroState = false, poundState = false;
        XmlDocument xmlDoc = new XmlDocument();
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            if (Takvim.Value != null)
            {
                string gun = Takvim.Value.Day <= 9 ? "0" + Takvim.Value.Day.ToString() : Takvim.Value.Day.ToString();
                string ay = Takvim.Value.Month <= 9 ? "0" + Takvim.Value.Month.ToString() : Takvim.Value.Month.ToString();
                string yil = Takvim.Value.Year.ToString();

                try
                {
                    xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + gun + ay + yil + ".xml");
                    DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

                    label1.Text = tarih.ToString("dd/MM/yyyy");

                    #region KurDegeriGetir
                    if (CBoxKurTuru.SelectedItem != null)
                    {
                        if (CBoxKurTuru.SelectedItem.ToString() == "Dolar" && !dolarState)
                        {
                            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

                            DGridKurlar.Rows.Add("Dolar", USD);

                            dolarState = true;
                        }
                        else if (CBoxKurTuru.SelectedItem.ToString() == "Euro" && !euroState)
                        {
                            string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

                            DGridKurlar.Rows.Add("Euro", EUR);

                            euroState = true;
                        }
                        else if (CBoxKurTuru.SelectedItem.ToString() == "Pound" && !poundState)
                        {
                            string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

                            DGridKurlar.Rows.Add("Pound", GBP);

                            poundState = true;
                        }
                    }
                    #endregion
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Tatil Günü Seçmeyin!");
                }
                
                
            }
        }

        private void SelectedRow(string paraBirimi)
        {
            for (int i = 0; i < DGridKurlar.RowCount - 1; i++)
            {
                if (DGridKurlar.Rows[i].Cells[0].Value.ToString() == paraBirimi)
                {
                    DGridKurlar.Rows[i].Selected = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBoxKurTuru.Items.Add("Dolar");
            CBoxKurTuru.Items.Add("Euro");
            CBoxKurTuru.Items.Add("Pound");
            DGridTemizle();
        }

        private void Takvim_ValueChanged(object sender, EventArgs e)
        {
            dolarState = false;
            euroState = false;
            poundState = false;
            DGridKurlar.Rows.Clear();
        }

        private void CboxSelected(object sender, EventArgs e)
        {
            DGridTemizle();

            if (CBoxKurTuru.SelectedItem.ToString() == "Dolar")
            {
                SelectedRow("Dolar");
            }
            else if (CBoxKurTuru.SelectedItem.ToString() == "Euro")
            {
                SelectedRow("Euro");
            }
            else if (CBoxKurTuru.SelectedItem.ToString() == "Pound")
            {
                SelectedRow("Pound");
            }
        }

        public void DGridTemizle()
        {
            for (int i = 0; i < DGridKurlar.RowCount - 1; i++)
            {
                DGridKurlar.Rows[i].Selected = false;
            }
        }
    }
}
