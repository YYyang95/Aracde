
namespace Arcade
{
    partial class Car
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Carr = new System.Windows.Forms.PictureBox();
            this.Dumpster2 = new System.Windows.Forms.PictureBox();
            this.Dumpster1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Carr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dumpster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dumpster1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Carr
            // 
            this.Carr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Carr.Image = ((System.Drawing.Image)(resources.GetObject("Carr.Image")));
            this.Carr.Location = new System.Drawing.Point(74, 236);
            this.Carr.Name = "Carr";
            this.Carr.Size = new System.Drawing.Size(207, 135);
            this.Carr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carr.TabIndex = 5;
            this.Carr.TabStop = false;
            this.Carr.Click += new System.EventHandler(this.Carr_Click);
            // 
            // Dumpster2
            // 
            this.Dumpster2.Image = ((System.Drawing.Image)(resources.GetObject("Dumpster2.Image")));
            this.Dumpster2.Location = new System.Drawing.Point(313, 424);
            this.Dumpster2.Name = "Dumpster2";
            this.Dumpster2.Size = new System.Drawing.Size(112, 174);
            this.Dumpster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dumpster2.TabIndex = 6;
            this.Dumpster2.TabStop = false;
            this.Dumpster2.Click += new System.EventHandler(this.Dumpster2_Click);
            // 
            // Dumpster1
            // 
            this.Dumpster1.Image = ((System.Drawing.Image)(resources.GetObject("Dumpster1.Image")));
            this.Dumpster1.Location = new System.Drawing.Point(841, 159);
            this.Dumpster1.Name = "Dumpster1";
            this.Dumpster1.Size = new System.Drawing.Size(103, 147);
            this.Dumpster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dumpster1.TabIndex = 7;
            this.Dumpster1.TabStop = false;
            this.Dumpster1.Click += new System.EventHandler(this.Dumpster1_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Dumpster1);
            this.Controls.Add(this.Dumpster2);
            this.Controls.Add(this.Carr);
            this.Name = "Car";
            this.Size = new System.Drawing.Size(1151, 601);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Car_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Car_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Carr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dumpster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dumpster1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Carr;
        private System.Windows.Forms.PictureBox Dumpster2;
        private System.Windows.Forms.PictureBox Dumpster1;
    }
}
