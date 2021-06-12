using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace TrickOrTreat
{
    public partial class Form1 : Form
    {
        Game game;
        Random random;
        bool eventFlag;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            random = new Random();
            eventFlag = true;
            startGame();
            
        }

        private void startGame()
        {
            game = Game.getInstance(this.ClientSize.Width, this.ClientSize.Height);
            game.EndEvent += Game_EndEvent;

            generatorTimer.Interval = random.Next(500, 4000);
            batTimer.Interval = random.Next(5000, 25000);
            lifeTimer.Interval = random.Next(10000, 50000);
            totalScore.Text = game.totalScore.ToString();
            remainingLives.Text = game.totalLives.ToString();       

            moveTimer.Start();
            generatorTimer.Start();
            batTimer.Start();
            batDirection.Start();
            lifeTimer.Start();
        }

        private void Game_EndEvent(object sender, EventArgs e)
        {
            endGame();
        }

        private void endGame()
        {
            GameOver gameOverScreen = new GameOver(game.totalScore);
            moveTimer.Stop();
            generatorTimer.Stop();
            batTimer.Stop();
            batDirection.Stop();
            lifeTimer.Stop();
            game.resetGame();

            gameOverScreen.Width = this.Width;
            gameOverScreen.Height = this.Height;
            gameOverScreen.StartPosition = FormStartPosition.Manual;
            gameOverScreen.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            gameOverScreen.ShowDialog();
            //this.Visible = true;

        }

        private void keyClick(object sender, KeyEventArgs e)
        {
            if (!eventFlag) return;

            eventFlag = false;

            if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                    game.adjustAvatarsLeft(true);
                else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                    game.adjustAvatarsRight(true);

            Invalidate();
        }

        private void keyRelease(object sender, KeyEventArgs e)
        {
            eventFlag = true;

                if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                    game.adjustAvatarsLeft(false);

                else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                    game.adjustAvatarsRight(false);

            Invalidate();
        }
        
        private void moveTimerTick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            game.move();
            this.ResumeLayout();

            Invalidate();
            Thread.Sleep(1);
        }

        private void batTimerTick(object sender, EventArgs e)
        {
            game.makeBatAppear();
            if (game.totalScore > 50)
                batTimer.Interval = random.Next(3000, 13000);
            else
                batTimer.Interval = random.Next(5000, 25000);

            Invalidate();
        }


        private void lifeTimerTick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            lifeTimer.Interval = random.Next(50000, 200000);
            game.generateExtraLife();
            this.ResumeLayout();
            Invalidate();
        }

        private void generatorTimerTick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            generatorTimer.Interval = random.Next(500, 1000);
            if(game.getFallingObjectsCount() <= 5)
                    game.generateObjects();
            this.ResumeLayout();
            Invalidate();
        }

        private void paintOnForm(object sender, PaintEventArgs e)
        {
            this.SuspendLayout();
            game.draw(e.Graphics);

            totalScore.Text = game.totalScore.ToString();
            remainingLives.Text = game.totalLives.ToString();
            this.ResumeLayout();
        }

        private void batDirectionTick(object sender, EventArgs e)
        {
            game.changeBatDirection();
            batDirection.Interval = random.Next(600, 1800);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
