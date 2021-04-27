
namespace TrickOrTreat
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.title = new System.Windows.Forms.PictureBox();
            this.topClouds = new System.Windows.Forms.PictureBox();
            this.bottomClouds = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClouds)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(68, 204);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(420, 98);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.title.TabIndex = 0;
            this.title.TabStop = false;
            // 
            // topClouds
            // 
            this.topClouds.BackColor = System.Drawing.Color.Transparent;
            this.topClouds.Image = ((System.Drawing.Image)(resources.GetObject("topClouds.Image")));
            this.topClouds.Location = new System.Drawing.Point(-45, -86);
            this.topClouds.Name = "topClouds";
            this.topClouds.Size = new System.Drawing.Size(710, 284);
            this.topClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topClouds.TabIndex = 4;
            this.topClouds.TabStop = false;
            // 
            // bottomClouds
            // 
            this.bottomClouds.BackColor = System.Drawing.Color.Transparent;
            this.bottomClouds.Image = ((System.Drawing.Image)(resources.GetObject("bottomClouds.Image")));
            this.bottomClouds.Location = new System.Drawing.Point(-75, 471);
            this.bottomClouds.Name = "bottomClouds";
            this.bottomClouds.Size = new System.Drawing.Size(676, 297);
            this.bottomClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomClouds.TabIndex = 5;
            this.bottomClouds.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(195, 308);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(162, 79);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(195, 393);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(162, 79);
            this.helpButton.TabIndex = 2;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 673);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bottomClouds);
            this.Controls.Add(this.topClouds);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClouds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox topClouds;
        private System.Windows.Forms.PictureBox bottomClouds;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button helpButton;
    }
}