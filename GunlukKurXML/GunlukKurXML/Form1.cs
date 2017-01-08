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

        bool dolarState = false, euroState = false, poundState = false;
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
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
