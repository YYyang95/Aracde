
namespace Arcade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mathGame1 = new Arcade.MathGame();
            this.home1 = new Arcade.Home();
            this.button3 = new System.Windows.Forms.Button();
            this.flappybird1 = new Arcade.flappybird();
            this.button5 = new System.Windows.Forms.Button();
            this.theball1 = new Arcade.Theball();
            this.button4 = new System.Windows.Forms.Button();
            this.car1 = new Arcade.Car();
            this.button6 = new System.Windows.Forms.Button();
            this.theballLevel21 = new Arcade.TheballLevel2();
            this.maze1 = new Arcade.Maze();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Math Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mathGame1
            // 
            this.mathGame1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mathGame1.Location = new System.Drawing.Point(231, 12);
            this.mathGame1.Name = "mathGame1";
            this.mathGame1.Size = new System.Drawing.Size(1256, 608);
            this.mathGame1.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(231, 13);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1383, 607);
            this.home1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "Flappy Bird";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flappybird1
            // 
            this.flappybird1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flappybird1.Location = new System.Drawing.Point(220, 12);
            this.flappybird1.Name = "flappybird1";
            this.flappybird1.Size = new System.Drawing.Size(1354, 620);
            this.flappybird1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 65);
            this.button5.TabIndex = 7;
            this.button5.Text = "The Ball";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // theball1
            // 
            this.theball1.BackColor = System.Drawing.SystemColors.Highlight;
            this.theball1.Location = new System.Drawing.Point(220, 13);
            this.theball1.Name = "theball1";
            this.theball1.Size = new System.Drawing.Size(1267, 619);
            this.theball1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 70);
            this.button4.TabIndex = 9;
            this.button4.Text = "Car Game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.car1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car1.BackgroundImage")));
            this.car1.Location = new System.Drawing.Point(220, 13);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(1267, 632);
            this.car1.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 70);
            this.button6.TabIndex = 11;
            this.button6.Text = "The Ball Level 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // theballLevel21
            // 
            this.theballLevel21.BackColor = System.Drawing.SystemColors.HotTrack;
            this.theballLevel21.Location = new System.Drawing.Point(220, 12);
            this.theballLevel21.Name = "theballLevel21";
            this.theballLevel21.Size = new System.Drawing.Size(1267, 633);
            this.theballLevel21.TabIndex = 12;
            // 
            // maze1
            // 
            this.maze1.Location = new System.Drawing.Point(220, 12);
            this.maze1.Name = "maze1";
            this.maze1.Size = new System.Drawing.Size(1267, 633);
            this.maze1.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 453);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 70);
            this.button7.TabIndex = 14;
            this.button7.Text = "The Maze";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 649);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.maze1);
            this.Controls.Add(this.theballLevel21);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.theball1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.flappybird1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.mathGame1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MathGame mathGame1;
        private Home home1;
        private System.Windows.Forms.Button button3;
        private flappybird flappybird1;
        private System.Windows.Forms.Button button5;
        private Theball theball1;
        private System.Windows.Forms.Button button4;
        private Car car1;
        private System.Windows.Forms.Button button6;
        private TheballLevel2 theballLevel21;
        private Maze maze1;
        private System.Windows.Forms.Button button7;
    }
}

