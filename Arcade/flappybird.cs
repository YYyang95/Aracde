using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade
{
    public partial class flappybird : UserControl
    {
        public flappybird()
        {
            InitializeComponent();
        }

        int gravity = 10;
        int speed = 25;
        int scores = 0;

        private void flappybird_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                gravity = 15;
            }
        }

        private void flappybird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                gravity = -15;
            }
            else if(e.KeyCode == Keys.P)
            {
                timer1.Start();
            }
        }

        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipedown.Left -= speed;
            pipeup.Left -= speed;
            score.Text = "Score:" + scores;

            if(pipedown.Left < -10)
            {
                pipedown.Left = r.Next(250, 500);
                scores++;              
            }
            if (pipeup.Left < -10)
            {
                pipeup.Left = r.Next(300, 600);           
            }
            if (scores >= 10)
            {
                speed += 5;
            }
            if (flappy.Bounds.IntersectsWith(pipedown.Bounds) || flappy.Bounds.IntersectsWith(pipeup.Bounds) || flappy.Bounds.IntersectsWith(grass.Bounds))
            {
                score.Text = "Game over";
                timer1.Stop();
            }          
        }

        private void flappybird_Load(object sender, EventArgs e)
        {

        }

        private void flappy_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
