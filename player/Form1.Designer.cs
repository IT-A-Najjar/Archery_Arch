namespace player
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
            this.player = new System.Windows.Forms.PictureBox();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b3 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::player.Properties.Resources.idle;
            this.player.Location = new System.Drawing.Point(50, 112);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(105, 124);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Arrow
            // 
            this.Arrow.Image = global::player.Properties.Resources.arrow;
            this.Arrow.Location = new System.Drawing.Point(161, 146);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(63, 17);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Arrow.TabIndex = 1;
            this.Arrow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b3
            // 
            this.b3.Image = global::player.Properties.Resources.balloon_3;
            this.b3.Location = new System.Drawing.Point(317, 219);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(31, 45);
            this.b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b3.TabIndex = 2;
            this.b3.TabStop = false;
            // 
            // b2
            // 
            this.b2.Image = global::player.Properties.Resources.balloon_2;
            this.b2.Location = new System.Drawing.Point(459, 268);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(31, 45);
            this.b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b2.TabIndex = 3;
            this.b2.TabStop = false;
            // 
            // b1
            // 
            this.b1.Image = global::player.Properties.Resources.balloon_1;
            this.b1.Location = new System.Drawing.Point(393, 219);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(31, 45);
            this.b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b1.TabIndex = 4;
            this.b1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(1, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(677, 50);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_score.Font = new System.Drawing.Font("Traditional Arabic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_score.Location = new System.Drawing.Point(12, 2);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(95, 48);
            this.lbl_score.TabIndex = 6;
            this.lbl_score.Text = "score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 344);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.player);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_score;
    }
}

