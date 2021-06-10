namespace WindowsFormsAppQuizard
{
    partial class ScoreBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBoard));
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHigestScoreShow = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblYourScoreShow = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnPlayAgain.FlatAppearance.BorderSize = 3;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(128, 228);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(117, 31);
            this.btnPlayAgain.TabIndex = 12;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoreboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblScoreboard.Location = new System.Drawing.Point(150, 17);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(95, 20);
            this.lblScoreboard.TabIndex = 2;
            this.lblScoreboard.Text = "Scoreboard";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblHigestScoreShow);
            this.panel1.Controls.Add(this.lblHighestScore);
            this.panel1.Controls.Add(this.lblYourScoreShow);
            this.panel1.Controls.Add(this.lblYourScore);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPlayAgain);
            this.panel1.Controls.Add(this.lblScoreboard);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 303);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(251, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 31);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHigestScoreShow
            // 
            this.lblHigestScoreShow.AutoSize = true;
            this.lblHigestScoreShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHigestScoreShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(175)))), ((int)(((byte)(168)))));
            this.lblHigestScoreShow.Location = new System.Drawing.Point(203, 162);
            this.lblHigestScoreShow.Name = "lblHigestScoreShow";
            this.lblHigestScoreShow.Size = new System.Drawing.Size(86, 46);
            this.lblHigestScoreShow.TabIndex = 17;
            this.lblHigestScoreShow.Text = "160";
            this.lblHigestScoreShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHighestScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblHighestScore.Location = new System.Drawing.Point(197, 133);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(97, 17);
            this.lblHighestScore.TabIndex = 16;
            this.lblHighestScore.Text = "Highest Score";
            // 
            // lblYourScoreShow
            // 
            this.lblYourScoreShow.AutoSize = true;
            this.lblYourScoreShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourScoreShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(175)))), ((int)(((byte)(168)))));
            this.lblYourScoreShow.Location = new System.Drawing.Point(208, 87);
            this.lblYourScoreShow.Name = "lblYourScoreShow";
            this.lblYourScoreShow.Size = new System.Drawing.Size(64, 46);
            this.lblYourScoreShow.TabIndex = 15;
            this.lblYourScoreShow.Text = "80";
            this.lblYourScoreShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblYourScore.Location = new System.Drawing.Point(210, 70);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(79, 17);
            this.lblYourScore.TabIndex = 14;
            this.lblYourScore.Text = "Your Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(417, 327);
            this.Controls.Add(this.panel1);
            this.Name = "ScoreBoard";
            this.Text = "Scoreboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScoreBoard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblScoreboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYourScoreShow;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHigestScoreShow;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Button btnExit;
    }
}