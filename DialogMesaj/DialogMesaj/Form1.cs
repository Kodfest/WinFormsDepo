using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogMesaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Devam Etmek İstiyor Musun?", "Onay Ekranı", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                button1.Text = "Evet";
            }
            else if (result == DialogResult.No)
            {
                button1.Text = "Hayır";
            }
            else
            {
                button1.Text = "Cancel";
            }
        }
    }
}
