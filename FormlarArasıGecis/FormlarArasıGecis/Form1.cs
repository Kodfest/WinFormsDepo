using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            frm.mesaj = textBox1.Text;
            frm.Show();
            this.Hide();
        }
    }
}
