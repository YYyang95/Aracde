using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car1.Hide();
            mathGame1.Hide();
            maze1.Hide();
            flappybird1.Hide();
            theball1.Hide();
            theballLevel21.Hide();
            home1.Show();
            home1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car1.Hide();
            home1.Hide();
            flappybird1.Hide();
            theball1.Hide();
            theballLevel21.Hide();
            maze1.Hide();
            mathGame1.Show();
            mathGame1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car1.Hide();
            home1.Hide();
            mathGame1.Hide();
            maze1.Hide();
            theball1.Hide();
            theballLevel21.Hide();
            flappybird1.Show();
            flappybird1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            car1.Hide();
            home1.Hide();
            mathGame1.Hide();
            maze1.Hide();
            flappybird1.Hide();
            theballLevel21.Hide();
            theball1.Show();
            theball1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home1.Hide();
            mathGame1.Hide();
            maze1.Hide();
            flappybird1.Hide();
            theball1.Hide();
            theballLevel21.Hide();
            car1.Show();
            car1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            home1.Hide();
            mathGame1.Hide();
            maze1.Hide();
            flappybird1.Hide();
            theballLevel21.Show();
            theballLevel21.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {        
            home1.Hide();
            mathGame1.Hide();
            flappybird1.Hide();
            theballLevel21.Hide();
            maze1.Show();
            maze1.BringToFront();
        }
    }
}
