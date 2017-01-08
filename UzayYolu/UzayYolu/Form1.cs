using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int genislik = Form1.ActiveForm.Width;
        int yukseklik = Form1.ActiveForm.Height;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    SpaceShip.Left -= 30;
                    break;
                case Keys.Right:
                    SpaceShip.Left += 30;
                    break;
                case Keys.Up:
                    SpaceShip.Top -= 30;
                    break;
                case Keys.Down:
                    SpaceShip.Top += 30;
                    break;
                case Keys.Space:
                    timer1.Start();
                    break;
                default:
                    break;
            }

            if (SpaceShip.Location.X > genislik - SpaceShip.Width)
            {
                MessageBox.Show("Game Over");
                SpaceShip.Location = new Point(0, 0);
            }

            if (SpaceShip.Location.Y > yukseklik - SpaceShip.Height)
            {
                MessageBox.Show("Game Over");
                SpaceShip.Location = new Point(0, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;

            int x = SpaceShip.Location.X - bomba.Width / 2;
            int y = SpaceShip.Location.Y - bomba.Height / 2;
            bomba.Location = new Point(x, y);
            
            if (bomba.Location.X < genislik - bomba.Width)
            {
                bomba.Left += 10;
            }
            else
            {
                timer1.Stop();
                bomba.Visible = false;
            }
        }
    }
}