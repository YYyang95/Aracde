using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade
{
    public partial class Car : UserControl
    {
        public Car()
        {
            InitializeComponent();
        }
        int movment = 10;
        int speed = 25;

        private void Car_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                movment = 15;
            }
        }
        private void Car_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                movment = -15;
            }
            else if (e.KeyCode == Keys.P)
            {
                timer1.Start();
            }
        }

        Random ran = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Carr.Top += movment;
            Dumpster1.Left -= speed;
            Dumpster2.Left -= speed;       
      
            if (Dumpster1.Left < -100)
            {
                Dumpster1.Left = ran.Next(2000, 2200);
            }
            if (Dumpster2.Left < -100)
            {
                Dumpster2.Left = ran.Next(1200, 1600);
            }               
            if (Carr.Bounds.IntersectsWith(Dumpster1.Bounds) || Carr.Bounds.IntersectsWith(Dumpster2.Bounds))
            {             
                timer1.Stop();
            }
        }
        private void Carr_Click(object sender, EventArgs e)
        {

        }

        private void Dumpster3_Click(object sender, EventArgs e)
        {

        }

        private void Dumpster2_Click(object sender, EventArgs e)
        {

        }

        private void Dumpster1_Click(object sender, EventArgs e)
        {

        }
    }
}

