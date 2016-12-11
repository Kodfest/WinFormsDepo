using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool UrlIsValid(string url)
        {
            bool result = false;

            try
            {
                IPHostEntry ipHost = Dns.Resolve(url);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
        private void BtnGit_Click(object sender, EventArgs e)
        {
            try
            {
                if(UrlIsValid(TxtURL.Text))
                {
                    Tarayici.Navigate(TxtURL.Text);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Site adresi hatalı!\nLütfen Yeniden Deneyiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Takvim_ValueChanged(object sender, EventArgs e)
        {

            //TxtYas.Text = DateTime.Now.ToString(); //Anlık Tarihi ve Saati verir

            TxtYas.Text = Math.Floor(DateTime.Now.Subtract(Takvim.Value).TotalDays / 365.25).ToString();

            //DateTime.Now.Subtract(Takvim.Value).TotalDays / 365.25
        }

        private void BtnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                PicBox.ImageLocation = dialog.FileName;
            }
        }
    }
}
