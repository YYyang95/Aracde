using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade
{
    public partial class MathGame : UserControl
    {
        public int timeleft;
        public int a;
        public int c;
        public MathGame()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timeleft = 7;         
            Random r = new Random();
            a = r.Next(2, 10);
            c = r.Next(2, 10);
            label1.Text = a.ToString();
            label3.Text = c.ToString();

            timer1.Start();

            Start.Enabled = false;
            Done.Enabled = true;       
        }     
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                label4.Text = timeleft.ToString();
            }
            if(timeleft == 0)
            {
                Done.Enabled = false;
                Start.Enabled = true;
                timer1.Stop();
                label4.Text = "You are the Loser!";
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Done.Enabled = false;
            Start.Enabled = true;
            timer1.Stop();
            
                int b = a * c;
                if (answer.Text == b.ToString())
                {
                    timer1.Stop();
                    label4.Text = "You are the Winner!";
                }
                else
                {
                    label4.Text = "You are the Loser!";
                }          
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void MathGame_Load(object sender, EventArgs e)
        {

        }
    }
}
