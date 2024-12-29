
namespace Arcade
{
    partial class flappybird
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
            this.flappy = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            this.SuspendLayout();
            // 
            // flappy
            // 
            this.flappy.Image = global::Arcade.Properties.Resources._1_ey7wIxpYa7Er7nRHhwyirQ;
            this.flappy.Location = new System.Drawing.Point(164, 240);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(123, 78);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 1;
            this.flappy.TabStop = false;
            this.flappy.Click += new System.EventHandler(this.flappy_Click);
            // 
            // grass
            // 
            this.grass.Image = global::Arcade.Properties.Resources.download;
            this.grass.Location = new System.Drawing.Point(-1, 553);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(1354, 67);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass.TabIndex = 2;
            this.grass.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(15, 582);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(78, 25);
            this.score.TabIndex = 3;
            this.score.Text = "Score: 0";
            // 
            // pipeup
            // 
            this.pipeup.Image = global::Arcade.Properties.Resources._6d2a698f31595a1;
            this.pipeup.Location = new System.Drawing.Point(399, 352);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(78, 206);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 5;
            this.pipeup.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = global::Arcade.Properties.Resources.images;
            this.pipedown.Location = new System.Drawing.Point(507, 0);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(60, 186);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 6;
            this.pipedown.TabStop = false;
            this.pipedown.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // flappybird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.score);
            this.Controls.Add(this.grass);
            this.Controls.Add(this.flappy);
            this.Name = "flappybird";
            this.Size = new System.Drawing.Size(1354, 620);
            this.Load += new System.EventHandler(this.flappybird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flappybird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flappybird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox pipedown;
    }
}
