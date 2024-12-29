using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade
{
    public partial class Theball : UserControl
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int scores = 0;
        public Theball()
        {
            InitializeComponent();
        }
        private void Theball_KeyDown(object sender, KeyEventArgs e)
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
                scores += 1;                                 
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
        }     

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {       
        }
    }
}
