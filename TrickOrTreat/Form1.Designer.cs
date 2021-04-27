
namespace TrickOrTreat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kittyAvatar = new System.Windows.Forms.PictureBox();
            this.bottomClouds = new System.Windows.Forms.PictureBox();
            this.topClouds = new System.Windows.Forms.PictureBox();
            this.totalScore = new System.Windows.Forms.Label();
            this.remainingLives = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kittyAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kittyAvatar
            // 
            this.kittyAvatar.BackColor = System.Drawing.Color.Transparent;
            this.kittyAvatar.Image = ((System.Drawing.Image)(resources.GetObject("kittyAvatar.Image")));
            this.kittyAvatar.Location = new System.Drawing.Point(110, 301);
            this.kittyAvatar.Name = "kittyAvatar";
            this.kittyAvatar.Size = new System.Drawing.Size(85, 85);
            this.kittyAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kittyAvatar.TabIndex = 1;
            this.kittyAvatar.TabStop = false;
            // 
            // bottomClouds
            // 
            this.bottomClouds.BackColor = System.Drawing.Color.Transparent;
            this.bottomClouds.Image = ((System.Drawing.Image)(resources.GetObject("bottomClouds.Image")));
            this.bottomClouds.Location = new System.Drawing.Point(-75, 471);
            this.bottomClouds.Name = "bottomClouds";
            this.bottomClouds.Size = new System.Drawing.Size(676, 297);
            this.bottomClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomClouds.TabIndex = 2;
            this.bottomClouds.TabStop = false;
            // 
            // topClouds
            // 
            this.topClouds.BackColor = System.Drawing.Color.Transparent;
            this.topClouds.Image = ((System.Drawing.Image)(resources.GetObject("topClouds.Image")));
            this.topClouds.Location = new System.Drawing.Point(-45, -86);
            this.topClouds.Name = "topClouds";
            this.topClouds.Size = new System.Drawing.Size(710, 284);
            this.topClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topClouds.TabIndex = 3;
            this.topClouds.TabStop = false;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.BackColor = System.Drawing.Color.Transparent;
            this.totalScore.Font = new System.Drawing.Font("Matura MT Script Capitals", 17.8F);
            this.totalScore.Location = new System.Drawing.Point(3, 1);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(37, 40);
            this.totalScore.TabIndex = 4;
            this.totalScore.Text = "0";
            // 
            // remainingLives
            // 
            this.remainingLives.AutoSize = true;
            this.remainingLives.BackColor = System.Drawing.Color.Transparent;
            this.remainingLives.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.remainingLives.ForeColor = System.Drawing.Color.OrangeRed;
            this.remainingLives.Location = new System.Drawing.Point(20, 34);
            this.remainingLives.Name = "remainingLives";
            this.remainingLives.Size = new System.Drawing.Size(20, 22);
            this.remainingLives.TabIndex = 5;
            this.remainingLives.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.remainingLives);
            this.Controls.Add(this.totalScore);
            this.Controls.Add(this.kittyAvatar);
            this.Controls.Add(this.topClouds);
            this.Controls.Add(this.bottomClouds);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 720);
            this.MinimumSize = new System.Drawing.Size(570, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kittyAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kittyAvatar;
        private System.Windows.Forms.PictureBox bottomClouds;
        private System.Windows.Forms.PictureBox topClouds;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label remainingLives;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

