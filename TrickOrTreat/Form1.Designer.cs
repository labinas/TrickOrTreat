
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kittyAvatar = new System.Windows.Forms.PictureBox();
            this.totalScore = new System.Windows.Forms.Label();
            this.remainingLives = new System.Windows.Forms.Label();
            this.lifeIcon = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.catBowl = new System.Windows.Forms.PictureBox();
            this.fishSkeleton = new System.Windows.Forms.PictureBox();
            this.milk = new System.Windows.Forms.PictureBox();
            this.rat = new System.Windows.Forms.PictureBox();
            this.extraLife = new System.Windows.Forms.PictureBox();
            this.angryChocolate = new System.Windows.Forms.PictureBox();
            this.salmon = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyBat = new System.Windows.Forms.PictureBox();
            this.batTimer = new System.Windows.Forms.Timer(this.components);
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.batMover = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kittyAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBowl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishSkeleton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angryChocolate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBat)).BeginInit();
            this.SuspendLayout();
            // 
            // kittyAvatar
            // 
            this.kittyAvatar.BackColor = System.Drawing.Color.Transparent;
            this.kittyAvatar.Image = global::TrickOrTreat.Properties.Resources.Left;
            this.kittyAvatar.Location = new System.Drawing.Point(464, 656);
            this.kittyAvatar.Name = "kittyAvatar";
            this.kittyAvatar.Size = new System.Drawing.Size(85, 85);
            this.kittyAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kittyAvatar.TabIndex = 1;
            this.kittyAvatar.TabStop = false;
            this.kittyAvatar.Tag = "avatar";
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
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Location = new System.Drawing.Point(266, -128);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(318, 214);
            this.cloud1.TabIndex = 7;
            this.cloud1.TabStop = false;
            this.cloud1.Tag = "x";
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.BackgroundImage = global::TrickOrTreat.Properties.Resources.cloud2;
            this.cloud2.Location = new System.Drawing.Point(0, 1);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(331, 137);
            this.cloud2.TabIndex = 8;
            this.cloud2.TabStop = false;
            this.cloud2.Tag = "x";
            // 
            // catBowl
            // 
            this.catBowl.BackColor = System.Drawing.Color.Transparent;
            this.catBowl.BackgroundImage = global::TrickOrTreat.Properties.Resources.cat_bowl;
            this.catBowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catBowl.Location = new System.Drawing.Point(373, 23);
            this.catBowl.Name = "catBowl";
            this.catBowl.Size = new System.Drawing.Size(45, 35);
            this.catBowl.TabIndex = 9;
            this.catBowl.TabStop = false;
            this.catBowl.Tag = "c+2";
            // 
            // fishSkeleton
            // 
            this.fishSkeleton.BackColor = System.Drawing.Color.Transparent;
            this.fishSkeleton.BackgroundImage = global::TrickOrTreat.Properties.Resources.fish_skeleton;
            this.fishSkeleton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fishSkeleton.Location = new System.Drawing.Point(341, 1);
            this.fishSkeleton.Name = "fishSkeleton";
            this.fishSkeleton.Size = new System.Drawing.Size(50, 25);
            this.fishSkeleton.TabIndex = 10;
            this.fishSkeleton.TabStop = false;
            this.fishSkeleton.Tag = "c-5";
            // 
            // milk
            // 
            this.milk.BackColor = System.Drawing.Color.Transparent;
            this.milk.BackgroundImage = global::TrickOrTreat.Properties.Resources.milk_bottle;
            this.milk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.milk.Location = new System.Drawing.Point(457, 1);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(20, 45);
            this.milk.TabIndex = 11;
            this.milk.TabStop = false;
            this.milk.Tag = "c+1";
            // 
            // rat
            // 
            this.rat.BackColor = System.Drawing.Color.Transparent;
            this.rat.BackgroundImage = global::TrickOrTreat.Properties.Resources.rat;
            this.rat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rat.Location = new System.Drawing.Point(411, -4);
            this.rat.Name = "rat";
            this.rat.Size = new System.Drawing.Size(40, 30);
            this.rat.TabIndex = 12;
            this.rat.TabStop = false;
            this.rat.Tag = "c-1";
            // 
            // extraLife
            // 
            this.extraLife.BackColor = System.Drawing.Color.Transparent;
            this.extraLife.BackgroundImage = global::TrickOrTreat.Properties.Resources.life;
            this.extraLife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.extraLife.Location = new System.Drawing.Point(483, 23);
            this.extraLife.Name = "extraLife";
            this.extraLife.Size = new System.Drawing.Size(30, 30);
            this.extraLife.TabIndex = 13;
            this.extraLife.TabStop = false;
            this.extraLife.Tag = "+l";
            // 
            // angryChocolate
            // 
            this.angryChocolate.BackColor = System.Drawing.Color.Transparent;
            this.angryChocolate.BackgroundImage = global::TrickOrTreat.Properties.Resources.angry_chocolate;
            this.angryChocolate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.angryChocolate.Location = new System.Drawing.Point(337, 18);
            this.angryChocolate.Name = "angryChocolate";
            this.angryChocolate.Size = new System.Drawing.Size(30, 45);
            this.angryChocolate.TabIndex = 14;
            this.angryChocolate.TabStop = false;
            this.angryChocolate.Tag = "c-3";
            // 
            // salmon
            // 
            this.salmon.BackColor = System.Drawing.Color.Transparent;
            this.salmon.BackgroundImage = global::TrickOrTreat.Properties.Resources.cute_salmon;
            this.salmon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salmon.Location = new System.Drawing.Point(424, 38);
            this.salmon.Name = "salmon";
            this.salmon.Size = new System.Drawing.Size(40, 30);
            this.salmon.TabIndex = 15;
            this.salmon.TabStop = false;
            this.salmon.Tag = "c+3";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerTick);
            // 
            // enemyBat
            // 
            this.enemyBat.BackColor = System.Drawing.Color.Transparent;
            this.enemyBat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyBat.BackgroundImage")));
            this.enemyBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyBat.Location = new System.Drawing.Point(8, 8);
            this.enemyBat.Name = "enemyBat";
            this.enemyBat.Size = new System.Drawing.Size(80, 50);
            this.enemyBat.TabIndex = 16;
            this.enemyBat.TabStop = false;
            this.enemyBat.Tag = "-l";
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
            // batMover
            // 
            this.batMover.Interval = 500;
            this.batMover.Tick += new System.EventHandler(this.batMoverTick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 753);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.totalScore);
            this.Controls.Add(this.lifeIcon);
            this.Controls.Add(this.remainingLives);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.kittyAvatar);
            this.Controls.Add(this.rat);
            this.Controls.Add(this.catBowl);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.salmon);
            this.Controls.Add(this.extraLife);
            this.Controls.Add(this.fishSkeleton);
            this.Controls.Add(this.angryChocolate);
            this.Controls.Add(this.enemyBat);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 800);
            this.MinimumSize = new System.Drawing.Size(570, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyClick);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyRelease);
            ((System.ComponentModel.ISupportInitialize)(this.kittyAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBowl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishSkeleton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angryChocolate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kittyAvatar;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label remainingLives;
        private System.Windows.Forms.PictureBox lifeIcon;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox catBowl;
        private System.Windows.Forms.PictureBox fishSkeleton;
        private System.Windows.Forms.PictureBox milk;
        private System.Windows.Forms.PictureBox rat;
        private System.Windows.Forms.PictureBox extraLife;
        private System.Windows.Forms.PictureBox angryChocolate;
        private System.Windows.Forms.PictureBox salmon;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox enemyBat;
        private System.Windows.Forms.Timer batTimer;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Timer batMover;
    }
}

