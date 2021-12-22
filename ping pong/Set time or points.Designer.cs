namespace ping_pong
{
    partial class Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set));
            this.title_lbl = new System.Windows.Forms.Label();
            this.entry_txt = new System.Windows.Forms.TextBox();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(-1, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(357, 20);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Please enter a (time/number of points) as the limit";
            // 
            // entry_txt
            // 
            this.entry_txt.Location = new System.Drawing.Point(112, 32);
            this.entry_txt.MaxLength = 5;
            this.entry_txt.Name = "entry_txt";
            this.entry_txt.Size = new System.Drawing.Size(119, 20);
            this.entry_txt.TabIndex = 1;
            // 
            // confrim_btn
            // 
            this.confrim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confrim_btn.Location = new System.Drawing.Point(135, 58);
            this.confrim_btn.Name = "confrim_btn";
            this.confrim_btn.Size = new System.Drawing.Size(75, 23);
            this.confrim_btn.TabIndex = 2;
            this.confrim_btn.Text = "Confirm";
            this.confrim_btn.UseVisualStyleBackColor = true;
            this.confrim_btn.Click += new System.EventHandler(this.confrim_btn_Click);
            // 
            // Set
            // 
            this.AcceptButton = this.confrim_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(353, 95);
            this.Controls.Add(this.confrim_btn);
            this.Controls.Add(this.entry_txt);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Set";
            this.ShowIcon = false;
            this.Text = "Set time or points";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Set_FormClosed);
            this.Load += new System.EventHandler(this.Set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox entry_txt;
        private System.Windows.Forms.Button confrim_btn;
    }
}