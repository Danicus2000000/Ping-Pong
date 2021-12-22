namespace ping_pong
{
    partial class Ping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ping));
            this.racket = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.delayp1 = new System.Windows.Forms.Timer(this.components);
            this.playspace = new System.Windows.Forms.PictureBox();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.p2points_lbl = new System.Windows.Forms.Label();
            this.racketp2 = new System.Windows.Forms.PictureBox();
            this.timed_game = new System.Windows.Forms.Timer(this.components);
            this.time_or_points_target_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketp2)).BeginInit();
            this.SuspendLayout();
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(169, 120);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(20, 200);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(197, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(213, 42);
            this.score_lbl.TabIndex = 1;
            this.score_lbl.Text = "P1 Score: 0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.ImageLocation = "";
            this.ball.Location = new System.Drawing.Point(608, 384);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // delayp1
            // 
            this.delayp1.Interval = 16;
            this.delayp1.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // playspace
            // 
            this.playspace.Location = new System.Drawing.Point(0, -1);
            this.playspace.Name = "playspace";
            this.playspace.Size = new System.Drawing.Size(1300, 819);
            this.playspace.TabIndex = 3;
            this.playspace.TabStop = false;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_lbl.Location = new System.Drawing.Point(486, 226);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(153, 124);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over\r\n)-------------(\r\nF1- Retry\r\nESC- Quit";
            this.gameover_lbl.Visible = false;
            // 
            // p2points_lbl
            // 
            this.p2points_lbl.AutoSize = true;
            this.p2points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2points_lbl.Location = new System.Drawing.Point(820, 9);
            this.p2points_lbl.Name = "p2points_lbl";
            this.p2points_lbl.Size = new System.Drawing.Size(213, 42);
            this.p2points_lbl.TabIndex = 6;
            this.p2points_lbl.Text = "P2 Score: 0";
            // 
            // racketp2
            // 
            this.racketp2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racketp2.Location = new System.Drawing.Point(1250, 139);
            this.racketp2.Name = "racketp2";
            this.racketp2.Size = new System.Drawing.Size(20, 200);
            this.racketp2.TabIndex = 7;
            this.racketp2.TabStop = false;
            // 
            // timed_game
            // 
            this.timed_game.Interval = 1000;
            this.timed_game.Tick += new System.EventHandler(this.timed_game_Tick);
            // 
            // time_or_points_target_lbl
            // 
            this.time_or_points_target_lbl.AutoSize = true;
            this.time_or_points_target_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_or_points_target_lbl.Location = new System.Drawing.Point(486, 9);
            this.time_or_points_target_lbl.Name = "time_or_points_target_lbl";
            this.time_or_points_target_lbl.Size = new System.Drawing.Size(126, 31);
            this.time_or_points_target_lbl.TabIndex = 8;
            this.time_or_points_target_lbl.Text = "Time left:";
            this.time_or_points_target_lbl.Visible = false;
            // 
            // Ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.time_or_points_target_lbl);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.racketp2);
            this.Controls.Add(this.gameover_lbl);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.p2points_lbl);
            this.Controls.Add(this.playspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ping";
            this.Text = "Ping pong";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ping_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer delayp1;
        private System.Windows.Forms.PictureBox playspace;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Label p2points_lbl;
        private System.Windows.Forms.PictureBox racketp2;
        private System.Windows.Forms.Timer timed_game;
        private System.Windows.Forms.Label time_or_points_target_lbl;
    }
}

