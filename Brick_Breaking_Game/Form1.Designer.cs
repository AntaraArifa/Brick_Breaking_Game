namespace Brick_Breaking_Game
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtscore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.BackColor = System.Drawing.Color.Transparent;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtscore.Location = new System.Drawing.Point(12, 9);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(161, 39);
            this.txtscore.TabIndex = 0;
            this.txtscore.Text = "Score : 0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player.Location = new System.Drawing.Point(445, 577);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 32);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ball.Location = new System.Drawing.Point(478, 515);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(28, 21);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.maingametimerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 621);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtscore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gametimer;
    }
}

