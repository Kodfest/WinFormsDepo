using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Size = new Size(500, 300);
            InitializeComponent();
            bomba.Visible = false;
        }

        
        int genislik = Form1.ActiveForm.Width;
        int yukseklik = Form1.ActiveForm.Height;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    SpaceShip.Left -= 10;
                    break;
                case Keys.Right:
                    SpaceShip.Left += 10;
                    break;
                case Keys.Up:
                    SpaceShip.Top -= 10;
                    break;
                case Keys.Down:
                    SpaceShip.Top += 10;
                    break;
                case Keys.Space:
                    int x = SpaceShip.Location.X + bomba.Width / 2;
                    int y = SpaceShip.Location.Y + bomba.Height / 2;
                    timer1.Start();
                    bomba.Visible = true;
                    
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