using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade
{
    public partial class Maze : UserControl
    {

        public int timeleft;

        public Maze()
        {
            InitializeComponent();                      
        }
        private void Maze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                timeleft = 16;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {        
            if (timeleft > 0)
            {
                timeleft--;
                Timer.Text = timeleft.ToString();
            }
            if (timeleft == 0)
            {
                timer1.Stop();
                Timer.Text = "You lose";
            }
        }    
        private void pictureBox46_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer.Text = "You lose";
        }

        private void WinBox_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer.Text = "You win";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }     
    }
}
