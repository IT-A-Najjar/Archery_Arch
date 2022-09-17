using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace player
{
    public partial class Form1 : Form
    {
        //class name:Form1
        //{
        //    public void shoot()
        //    {
        //        Arrow.Left += 100;
        //        if (Arrow.Left > 600)
        //        {
        //            player.Image = Properties.Resources.idle;
        //            Arrow.Image = Properties.Resources.arrow;
        //            Arrow.Top = player.Top + 35;
        //        }
        //    }
        //}
        void shoot()
        {
            Arrow.Left += 100;
            if (Arrow.Left > 600)
            {
                player.Image = Properties.Resources.idle;
                Arrow.Image = Properties.Resources.arrow;
                Arrow.Top = player.Top + 35;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Arrow.Left = player.Left;
                player.Image = Properties.Resources.shoot;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (player.Top >35)
                {
                    player.Top -= 10;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (player.Top <120)
                {
                    player.Top += 10;
                }
            }
        }
        public void Balloon()
        {
            Random rnd = new Random();
            int x, y, z;
            if (b1.Top < 20)
            {
                b1.Top = 300;
                x = rnd.Next(200, 600);
                b1.Location = new Point(x, 500);
            }
            if (b2.Top < 20)
            {
                b2.Top = 300;
                y = rnd.Next(200, 600);
                b2.Location = new Point(y, 500);
            }
            if (b3.Top < 20)
            {
                b3.Top = 300;
                z = rnd.Next(200, 600);
                b3.Location = new Point(z, 500);
            }
            else
            {
                if (score <= 10)
                {
                    b1.Top -= 5;
                    b2.Top -= 8;
                    b3.Top -= 10;
                }
                else if (score > 10 && score <= 20)
                {
                    b1.Top -= 7;
                    b2.Top -= 11;
                    b3.Top -= 15;
                }
                else
                {
                    b1.Top -= 10;
                    b2.Top -= 16;
                    b3.Top -= 20;
                }
            }
        }
        int score;
        public void Game()
        {
            if (Arrow.Bounds.IntersectsWith(b1.Bounds))
            {
                b1.Top = 400;
                score += 1;
                lbl_score.Text = "Score :" + score;
                Arrow.Image = Properties.Resources.Explosion;
                if (score == 10)
                {
                    MessageBox.Show("1");
                    //score = 0;
                }
                else if (score == 20)
                {
                    MessageBox.Show("2");
                }
            }
            if (Arrow.Bounds.IntersectsWith(b2.Bounds))
            {
                b2.Top = 400;
                score += 1;
                lbl_score.Text = "Score :" + score;
                Arrow.Image = Properties.Resources.Explosion;
                if (score == 10)
                {
                    MessageBox.Show("1");
                    //score = 0;
                }
                else if (score == 20)
                {
                    MessageBox.Show("2");
                }
            }
            if (Arrow.Bounds.IntersectsWith(b3.Bounds))
            {
                b3.Top = 400;
                score += 1;
                lbl_score.Text = "Score :" + score;
                Arrow.Image = Properties.Resources.Explosion;
                if (score == 10)
                {
                    MessageBox.Show("1");
                    //score = 0;
                }
                else if (score == 20)
                {
                    MessageBox.Show("2");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //name a = new name();
            //a.shoot();
            shoot();
            Balloon();
            Game();
        }
    }
}
