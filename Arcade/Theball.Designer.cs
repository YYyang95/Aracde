
namespace Arcade
{
    partial class Theball
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.hit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hit)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Desktop;
            this.ball.Location = new System.Drawing.Point(392, 159);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(23, 24);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // hit
            // 
            this.hit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hit.Location = new System.Drawing.Point(367, 339);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(158, 28);
            this.hit.TabIndex = 1;
            this.hit.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(17, 16);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(91, 32);
            this.score.TabIndex = 2;
            this.score.Text = "Score:0";
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // Theball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.score);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.hit);
            this.Name = "Theball";
            this.Size = new System.Drawing.Size(995, 518);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Theball_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox hit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
    }
}
