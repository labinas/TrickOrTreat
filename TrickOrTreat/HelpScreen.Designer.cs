
namespace TrickOrTreat
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            this.topClouds = new System.Windows.Forms.PictureBox();
            this.bottomClouds = new System.Windows.Forms.PictureBox();
            this.helpText = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpText)).BeginInit();
            this.SuspendLayout();
            // 
            // topClouds
            // 
            this.topClouds.BackColor = System.Drawing.Color.Transparent;
            this.topClouds.Image = ((System.Drawing.Image)(resources.GetObject("topClouds.Image")));
            this.topClouds.Location = new System.Drawing.Point(-45, -85);
            this.topClouds.Name = "topClouds";
            this.topClouds.Size = new System.Drawing.Size(710, 284);
            this.topClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topClouds.TabIndex = 5;
            this.topClouds.TabStop = false;
            // 
            // bottomClouds
            // 
            this.bottomClouds.BackColor = System.Drawing.Color.Transparent;
            this.bottomClouds.Image = ((System.Drawing.Image)(resources.GetObject("bottomClouds.Image")));
            this.bottomClouds.Location = new System.Drawing.Point(-75, 513);
            this.bottomClouds.Name = "bottomClouds";
            this.bottomClouds.Size = new System.Drawing.Size(676, 255);
            this.bottomClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomClouds.TabIndex = 6;
            this.bottomClouds.TabStop = false;
            // 
            // helpText
            // 
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Image = ((System.Drawing.Image)(resources.GetObject("helpText.Image")));
            this.helpText.Location = new System.Drawing.Point(-3, 163);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(565, 344);
            this.helpText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpText.TabIndex = 7;
            this.helpText.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkGray;
            this.backButton.Location = new System.Drawing.Point(252, 472);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(57, 35);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // HelpScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 673);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.bottomClouds);
            this.Controls.Add(this.topClouds);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            ((System.ComponentModel.ISupportInitialize)(this.topClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topClouds;
        private System.Windows.Forms.PictureBox bottomClouds;
        private System.Windows.Forms.PictureBox helpText;
        private System.Windows.Forms.Button backButton;
    }
}