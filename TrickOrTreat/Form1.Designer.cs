
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
            this.components = new System.ComponentModel.Container();
            this.totalScore = new System.Windows.Forms.Label();
            this.remainingLives = new System.Windows.Forms.Label();
            this.lifeIcon = new System.Windows.Forms.PictureBox();
            this.batTimer = new System.Windows.Forms.Timer(this.components);
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.generatorTimer = new System.Windows.Forms.Timer(this.components);
            this.batDirection = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.BackColor = System.Drawing.Color.Transparent;
            this.totalScore.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.Location = new System.Drawing.Point(3, 1);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(28, 30);
            this.totalScore.TabIndex = 4;
            this.totalScore.Text = "0";
            // 
            // remainingLives
            // 
            this.remainingLives.AutoSize = true;
            this.remainingLives.BackColor = System.Drawing.Color.Transparent;
            this.remainingLives.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLives.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.remainingLives.Location = new System.Drawing.Point(20, 38);
            this.remainingLives.Name = "remainingLives";
            this.remainingLives.Size = new System.Drawing.Size(20, 20);
            this.remainingLives.TabIndex = 5;
            this.remainingLives.Text = "3";
            // 
            // lifeIcon
            // 
            this.lifeIcon.BackColor = System.Drawing.Color.Transparent;
            this.lifeIcon.Image = global::TrickOrTreat.Properties.Resources.lives_icon;
            this.lifeIcon.Location = new System.Drawing.Point(0, 34);
            this.lifeIcon.Name = "lifeIcon";
            this.lifeIcon.Size = new System.Drawing.Size(24, 29);
            this.lifeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lifeIcon.TabIndex = 6;
            this.lifeIcon.TabStop = false;
            this.lifeIcon.Tag = "x";
            // 
            // batTimer
            // 
            this.batTimer.Interval = 12000;
            this.batTimer.Tick += new System.EventHandler(this.batTimerTick);
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerTick);
            // 
            // lifeTimer
            // 
            this.lifeTimer.Interval = 7000;
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimerTick);
            // 
            // generatorTimer
            // 
            this.generatorTimer.Interval = 500;
            this.generatorTimer.Tick += new System.EventHandler(this.generatorTimerTick);
            // 
            // batDirection
            // 
            this.batDirection.Interval = 600;
            this.batDirection.Tick += new System.EventHandler(this.batDirectionTick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TrickOrTreat.Properties.Resources.BackgroundResized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 753);
            this.Controls.Add(this.totalScore);
            this.Controls.Add(this.lifeIcon);
            this.Controls.Add(this.remainingLives);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 800);
            this.MinimumSize = new System.Drawing.Size(570, 800);
            this.Name = "Form1";
            this.Text = "Trick or Treat!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paintOnForm);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyClick);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyRelease);
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label remainingLives;
        private System.Windows.Forms.PictureBox lifeIcon;
        private System.Windows.Forms.Timer batTimer;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Timer generatorTimer;
        private System.Windows.Forms.Timer batDirection;
    }
}

