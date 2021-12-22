namespace ping_pong
{
    partial class Start_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_screen));
            this.infinitemode_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.timedmode_btn = new System.Windows.Forms.Button();
            this.pointsmode_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soundon_lbl = new System.Windows.Forms.Label();
            this.flashing_light = new System.Windows.Forms.Timer(this.components);
            this.epilepsy_warning = new System.Windows.Forms.RichTextBox();
            this.bgflash_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infinitemode_btn
            // 
            this.infinitemode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infinitemode_btn.Location = new System.Drawing.Point(12, 47);
            this.infinitemode_btn.Name = "infinitemode_btn";
            this.infinitemode_btn.Size = new System.Drawing.Size(75, 47);
            this.infinitemode_btn.TabIndex = 0;
            this.infinitemode_btn.Text = "Infinite Mode";
            this.infinitemode_btn.UseVisualStyleBackColor = true;
            this.infinitemode_btn.Click += new System.EventHandler(this.infinitemode_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(113, 15);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(111, 25);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Ping Pong";
            // 
            // timedmode_btn
            // 
            this.timedmode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timedmode_btn.Location = new System.Drawing.Point(93, 47);
            this.timedmode_btn.Name = "timedmode_btn";
            this.timedmode_btn.Size = new System.Drawing.Size(75, 47);
            this.timedmode_btn.TabIndex = 2;
            this.timedmode_btn.Text = "Timed Mode";
            this.timedmode_btn.UseVisualStyleBackColor = true;
            this.timedmode_btn.Click += new System.EventHandler(this.timedmode_btn_Click);
            // 
            // pointsmode_btn
            // 
            this.pointsmode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pointsmode_btn.Location = new System.Drawing.Point(174, 47);
            this.pointsmode_btn.Name = "pointsmode_btn";
            this.pointsmode_btn.Size = new System.Drawing.Size(75, 47);
            this.pointsmode_btn.TabIndex = 3;
            this.pointsmode_btn.Text = "Points Mode";
            this.pointsmode_btn.UseVisualStyleBackColor = true;
            this.pointsmode_btn.Click += new System.EventHandler(this.pointsmode_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings_btn.Location = new System.Drawing.Point(255, 47);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 47);
            this.settings_btn.TabIndex = 4;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 96);
            this.label1.TabIndex = 5;
            this.label1.Text = "Controls\r\n)--------(\r\nF1-Reset\r\nEsc- Quit";
            // 
            // soundon_lbl
            // 
            this.soundon_lbl.AutoSize = true;
            this.soundon_lbl.Location = new System.Drawing.Point(9, 9);
            this.soundon_lbl.Name = "soundon_lbl";
            this.soundon_lbl.Size = new System.Drawing.Size(58, 13);
            this.soundon_lbl.TabIndex = 6;
            this.soundon_lbl.Text = "Sound: On";
            // 
            // flashing_light
            // 
            this.flashing_light.Enabled = true;
            this.flashing_light.Interval = 1;
            // 
            // epilepsy_warning
            // 
            this.epilepsy_warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.epilepsy_warning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.epilepsy_warning.Location = new System.Drawing.Point(12, 138);
            this.epilepsy_warning.Name = "epilepsy_warning";
            this.epilepsy_warning.ReadOnly = true;
            this.epilepsy_warning.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.epilepsy_warning.Size = new System.Drawing.Size(89, 18);
            this.epilepsy_warning.TabIndex = 12;
            this.epilepsy_warning.Text = "Epilepsy Warning!";
            // 
            // bgflash_lbl
            // 
            this.bgflash_lbl.AutoSize = true;
            this.bgflash_lbl.Location = new System.Drawing.Point(9, 27);
            this.bgflash_lbl.Name = "bgflash_lbl";
            this.bgflash_lbl.Size = new System.Drawing.Size(70, 13);
            this.bgflash_lbl.TabIndex = 13;
            this.bgflash_lbl.Text = "BG Flash: Off";
            // 
            // Start_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(340, 199);
            this.Controls.Add(this.bgflash_lbl);
            this.Controls.Add(this.epilepsy_warning);
            this.Controls.Add(this.soundon_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.pointsmode_btn);
            this.Controls.Add(this.timedmode_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.infinitemode_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start_screen";
            this.ShowIcon = false;
            this.Text = "Ping Pong";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_screen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infinitemode_btn;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button timedmode_btn;
        private System.Windows.Forms.Button pointsmode_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soundon_lbl;
        private System.Windows.Forms.Timer flashing_light;
        private System.Windows.Forms.RichTextBox epilepsy_warning;
        private System.Windows.Forms.Label bgflash_lbl;
    }
}