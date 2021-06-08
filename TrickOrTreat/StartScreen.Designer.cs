
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
            this.title = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = global::TrickOrTreat.Properties.Resources.trick_or_treat;
            this.title.Location = new System.Drawing.Point(12, 240);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(528, 113);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.title.TabIndex = 0;
            this.title.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::TrickOrTreat.Properties.Resources.button_play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(195, 348);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(162, 79);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButtonClicked);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = global::TrickOrTreat.Properties.Resources.button_help;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(195, 433);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(162, 79);
            this.helpButton.TabIndex = 2;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButtonClicked);
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TrickOrTreat.Properties.Resources.moving_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 753);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 800);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button helpButton;
    }
}