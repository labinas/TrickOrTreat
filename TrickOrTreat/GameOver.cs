using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrickOrTreat
{
    public partial class GameOver : Form
    {
        bool currentlyAnimating = false;
        bool isAnimating = true;
        int totalScore;
        HighScore highScore;

        public GameOver(int totalScore)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.totalScore = totalScore;
            highScore = new HighScore();
            loadHighScore();
            saveHighScore();
        }

        private void saveHighScore()
        {
            if(totalScore > highScore.highScore)
            {
                highScore.highScore = totalScore;
            }

            var serializer = new XmlSerializer(highScore.GetType());
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, highScore);
            }

        }

        private void loadHighScore()
        {
            var serializer = new XmlSerializer(highScore.GetType());
            object obj;
            try
            {
                using (var reader = new StreamReader("highscores.xml"))
                {
                    obj = serializer.Deserialize(reader.BaseStream);
                }
                highScore = (HighScore)obj;
            }
            catch(Exception ex)
            {
                highScore = new HighScore();
                return;
            }
            
        }

        public void animationImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(this.BackgroundImage, new EventHandler(this.onFormChanged));
                currentlyAnimating = true;
            }
        }

        private void onFormChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (isAnimating)
            {
                animationImage();
                ImageAnimator.UpdateFrames();
            }
            base.OnPaintBackground(e);
        }

        private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void tryAgainClicked(object sender, EventArgs e)
        {
            Form1 game = new Form1();

            game.Width = this.Width;
            game.Height = this.Height;
            game.StartPosition = FormStartPosition.Manual;
            game.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            game.ShowDialog();
            //this.Visible = true;

        }

        private void exitGameClicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            totalScoreText.Text = totalScore.ToString();
            highScoreText.Text = highScore.highScore.ToString();
        }

        private void clearHighScore(object sender, EventArgs e)
        {
            highScore = new HighScore();
            var serializer = new XmlSerializer(highScore.GetType());
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, highScore);
            }
            highScoreText.Text = highScore.highScore.ToString();
        }
    }
}
