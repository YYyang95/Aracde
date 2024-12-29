using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade
{
    public partial class TheballLevel2 : UserControl
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int scores = 0;
        public TheballLevel2()
        {
            InitializeComponent();  
        }
        private void TheballLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hit.Left = Cursor.Position.X - 300;

            ball.Left += speed_left;
            ball.Top += speed_top;
            score.Text = "Score:" + scores;

            if (ball.Bottom >= hit.Top && ball.Bottom <= hit.Bottom && ball.Left >= hit.Left && ball.Right <= hit.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;         
            }

            if (ball.Left < 0 || ball.Left > 800)
            {
                speed_left = -speed_left;
            }
            if (ball.Top < 0 || ball.Top > 800)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= 550)
            {
               timer1.Stop();
               score.Text = "Game over";
            }  
            if (scores == 12)
            {
                timer1.Stop();
                score.Text = "You win";
            }

                foreach (Control x in this.Controls)
                {
                if(x is PictureBox && (string)x.Tag == "Box")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        scores += 1;

                        speed_top = -speed_top;

                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }    
    }
}
