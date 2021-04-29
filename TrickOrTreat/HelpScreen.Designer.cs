
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
            this.helpText = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.helpText)).BeginInit();
            this.SuspendLayout();
            // 
            // helpText
            // 
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Image = global::TrickOrTreat.Properties.Resources.help_screen_pink;
            this.helpText.Location = new System.Drawing.Point(-5, 151);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(563, 433);
            this.helpText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpText.TabIndex = 7;
            this.helpText.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::TrickOrTreat.Properties.Resources.button_back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(247, 599);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(57, 35);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClicked);
            // 
            // HelpScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 753);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpText);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 800);
            this.MinimumSize = new System.Drawing.Size(570, 800);
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            ((System.ComponentModel.ISupportInitialize)(this.helpText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox helpText;
        private System.Windows.Forms.Button backButton;
    }
}