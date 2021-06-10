
namespace TrickOrTreat
{
    partial class GameOver
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalScoreText = new System.Windows.Forms.Label();
            this.highScoreText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TrickOrTreat.Properties.Resources.game_over_txt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-54, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // totalScoreText
            // 
            this.totalScoreText.AutoSize = true;
            this.totalScoreText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalScoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalScoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalScoreText.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreText.ForeColor = System.Drawing.Color.Black;
            this.totalScoreText.Location = new System.Drawing.Point(337, 265);
            this.totalScoreText.Name = "totalScoreText";
            this.totalScoreText.Size = new System.Drawing.Size(34, 42);
            this.totalScoreText.TabIndex = 1;
            this.totalScoreText.Text = "0";
            // 
            // highScoreText
            // 
            this.highScoreText.AutoSize = true;
            this.highScoreText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.highScoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highScoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoreText.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreText.ForeColor = System.Drawing.Color.Black;
            this.highScoreText.Location = new System.Drawing.Point(337, 315);
            this.highScoreText.Name = "highScoreText";
            this.highScoreText.Size = new System.Drawing.Size(34, 42);
            this.highScoreText.TabIndex = 3;
            this.highScoreText.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::TrickOrTreat.Properties.Resources.total_score_text;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(164, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 50);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::TrickOrTreat.Properties.Resources.high_score_text;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(164, 307);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 50);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.tryAgainButton.BackgroundImage = global::TrickOrTreat.Properties.Resources.button_try_again;
            this.tryAgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tryAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tryAgainButton.FlatAppearance.BorderSize = 0;
            this.tryAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tryAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryAgainButton.Location = new System.Drawing.Point(96, 586);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(161, 66);
            this.tryAgainButton.TabIndex = 1;
            this.tryAgainButton.UseVisualStyleBackColor = false;
            this.tryAgainButton.Click += new System.EventHandler(this.tryAgainClicked);
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.Transparent;
            this.exitGameButton.BackgroundImage = global::TrickOrTreat.Properties.Resources.button_exit_game;
            this.exitGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitGameButton.FlatAppearance.BorderSize = 0;
            this.exitGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGameButton.Location = new System.Drawing.Point(303, 586);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(161, 66);
            this.exitGameButton.TabIndex = 2;
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TrickOrTreat.Properties.Resources.bat_enemy;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(49, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 104);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BackgroundImage = global::TrickOrTreat.Properties.Resources.button_clear_high_score;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(227, 363);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 3;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearHighScore);
            // 
            // GameOver
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TrickOrTreat.Properties.Resources.moving_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 753);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.tryAgainButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.highScoreText);
            this.Controls.Add(this.totalScoreText);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "GameOver";
            this.Text = "Trick or Treat!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOver_FormClosing);
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totalScoreText;
        private System.Windows.Forms.Label highScoreText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button tryAgainButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button clearButton;
    }
}