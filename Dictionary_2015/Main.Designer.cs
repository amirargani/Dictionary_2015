namespace Dictionary_2015
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.P_1 = new System.Windows.Forms.Panel();
            this.P_2 = new System.Windows.Forms.Panel();
            this.LBL_1 = new System.Windows.Forms.Label();
            this.PICICON_1 = new System.Windows.Forms.PictureBox();
            this.P_3 = new System.Windows.Forms.Panel();
            this.LBL_2 = new System.Windows.Forms.Label();
            this.P_4 = new System.Windows.Forms.Panel();
            this.PICBACKGROUND_1 = new System.Windows.Forms.PictureBox();
            this.TIM_Opacity = new System.Windows.Forms.Timer(this.components);
            this.TIM_OpacityExit = new System.Windows.Forms.Timer(this.components);
            this.TIM_MusicPlay = new System.Windows.Forms.Timer(this.components);
            this.P_1.SuspendLayout();
            this.P_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICICON_1)).BeginInit();
            this.P_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBACKGROUND_1)).BeginInit();
            this.SuspendLayout();
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.P_1.Controls.Add(this.P_2);
            this.P_1.Controls.Add(this.PICICON_1);
            this.P_1.Controls.Add(this.P_3);
            this.P_1.Location = new System.Drawing.Point(0, 0);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(800, 100);
            this.P_1.TabIndex = 0;
            this.P_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_1_MouseDown);
            // 
            // P_2
            // 
            this.P_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.P_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_2.Controls.Add(this.LBL_1);
            this.P_2.Location = new System.Drawing.Point(758, 12);
            this.P_2.Name = "P_2";
            this.P_2.Size = new System.Drawing.Size(30, 30);
            this.P_2.TabIndex = 2;
            // 
            // LBL_1
            // 
            this.LBL_1.AutoSize = true;
            this.LBL_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_1.ForeColor = System.Drawing.SystemColors.Window;
            this.LBL_1.Location = new System.Drawing.Point(4, 0);
            this.LBL_1.Name = "LBL_1";
            this.LBL_1.Size = new System.Drawing.Size(21, 24);
            this.LBL_1.TabIndex = 1;
            this.LBL_1.Text = "x";
            this.LBL_1.Click += new System.EventHandler(this.LBL_1_Click);
            // 
            // PICICON_1
            // 
            this.PICICON_1.BackColor = System.Drawing.Color.Transparent;
            this.PICICON_1.Image = ((System.Drawing.Image)(resources.GetObject("PICICON_1.Image")));
            this.PICICON_1.Location = new System.Drawing.Point(12, 12);
            this.PICICON_1.Name = "PICICON_1";
            this.PICICON_1.Size = new System.Drawing.Size(100, 75);
            this.PICICON_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICICON_1.TabIndex = 2;
            this.PICICON_1.TabStop = false;
            // 
            // P_3
            // 
            this.P_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.P_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_3.Controls.Add(this.LBL_2);
            this.P_3.Location = new System.Drawing.Point(722, 12);
            this.P_3.Name = "P_3";
            this.P_3.Size = new System.Drawing.Size(30, 30);
            this.P_3.TabIndex = 2;
            // 
            // LBL_2
            // 
            this.LBL_2.AutoSize = true;
            this.LBL_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_2.ForeColor = System.Drawing.SystemColors.Window;
            this.LBL_2.Location = new System.Drawing.Point(4, 0);
            this.LBL_2.Name = "LBL_2";
            this.LBL_2.Size = new System.Drawing.Size(20, 25);
            this.LBL_2.TabIndex = 2;
            this.LBL_2.Text = "-";
            this.LBL_2.Click += new System.EventHandler(this.LBL_2_Click);
            // 
            // P_4
            // 
            this.P_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(221)))));
            this.P_4.Location = new System.Drawing.Point(0, 545);
            this.P_4.Name = "P_4";
            this.P_4.Size = new System.Drawing.Size(800, 55);
            this.P_4.TabIndex = 1;
            // 
            // PICBACKGROUND_1
            // 
            this.PICBACKGROUND_1.BackColor = System.Drawing.Color.Transparent;
            this.PICBACKGROUND_1.Image = ((System.Drawing.Image)(resources.GetObject("PICBACKGROUND_1.Image")));
            this.PICBACKGROUND_1.Location = new System.Drawing.Point(0, 106);
            this.PICBACKGROUND_1.Name = "PICBACKGROUND_1";
            this.PICBACKGROUND_1.Size = new System.Drawing.Size(800, 433);
            this.PICBACKGROUND_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBACKGROUND_1.TabIndex = 3;
            this.PICBACKGROUND_1.TabStop = false;
            // 
            // TIM_Opacity
            // 
            this.TIM_Opacity.Tick += new System.EventHandler(this.TIM_Opacity_Tick);
            // 
            // TIM_OpacityExit
            // 
            this.TIM_OpacityExit.Tick += new System.EventHandler(this.TIM_OpacityExit_Tick);
            // 
            // TIM_MusicPlay
            // 
            this.TIM_MusicPlay.Enabled = true;
            this.TIM_MusicPlay.Interval = 6000;
            this.TIM_MusicPlay.Tick += new System.EventHandler(this.TIM_MusicPlay_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.P_4);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.PICBACKGROUND_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary 2015";
            this.P_1.ResumeLayout(false);
            this.P_2.ResumeLayout(false);
            this.P_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICICON_1)).EndInit();
            this.P_3.ResumeLayout(false);
            this.P_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBACKGROUND_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Panel P_3;
        private System.Windows.Forms.Panel P_2;
        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Label LBL_2;
        private System.Windows.Forms.Panel P_4;
        private System.Windows.Forms.PictureBox PICICON_1;
        private System.Windows.Forms.PictureBox PICBACKGROUND_1;
        private System.Windows.Forms.Timer TIM_Opacity;
        private System.Windows.Forms.Timer TIM_OpacityExit;
        private System.Windows.Forms.Timer TIM_MusicPlay;
    }
}

