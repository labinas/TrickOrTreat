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

namespace TrickOrTreat
{
    public partial class Form1 : Form
    {
        Game game;
        Random random;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            game = new Game(this.Width, this.Height);
            random = new Random();
            this.Controls.Add(game.getAvatar().kittyAvatar);
            startGame();
        }

        private void startGame()
        {
            generatorTimer.Interval = random.Next(500, 4000);
            batTimer.Interval = random.Next(5000, 25000);
            lifeTimer.Interval = random.Next(10000, 50000);
            totalScore.Text = game.totalScore.ToString();
            remainingLives.Text = game.totalLives.ToString();

            

            moveTimer.Start();
            generatorTimer.Start();
            batTimer.Start();
            //batMover.Start();
            lifeTimer.Start();
        }

        private void endGame()
        {
            moveTimer.Stop();
            generatorTimer.Stop();
            batTimer.Stop();
            //batMover.Stop();
            lifeTimer.Stop();

            DialogResult dialogResult = MessageBox.Show("Game over!" + Environment.NewLine + "Better luck next time!"
                + Environment.NewLine + "Score: "
                + game.totalScore + Environment.NewLine + "Do you want to restart the game?"
                , "GAME OVER :(", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                startGame();
            }
            else if (dialogResult == DialogResult.No)
            {
                Environment.Exit(0);
            }

        }

        private void keyClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                game.adjustAvatarsLeft(true);
            else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                game.adjustAvatarsRight(true);

            Invalidate();
        }

        private void keyRelease(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                game.adjustAvatarsLeft(false);

            else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                game.adjustAvatarsRight(false);

            Invalidate();
        }
        
        private void moveTimerTick(object sender, EventArgs e)
        {
            if (game.gameOver)
                endGame();
            else
                game.move();

            Invalidate();
        }

        private void batTimerTick(object sender, EventArgs e)
        {
            game.makeBatAppear();
            batTimer.Interval = random.Next(5000, 25000);

            Invalidate();
        }


        private void lifeTimerTick(object sender, EventArgs e)
        {
            lifeTimer.Interval = random.Next(10000, 50000);
            game.generateExtraLife();
            
            Invalidate();
        }

        private void generatorTimerTick(object sender, EventArgs e)
        {
            generatorTimer.Interval = random.Next(500, 4000);
            game.generateObjects();

            Invalidate();
        }

        private void paintOnForm(object sender, PaintEventArgs e)
        {
            game.draw(e.Graphics);

            totalScore.Text = game.totalScore.ToString();
            remainingLives.Text = game.totalLives.ToString();
        }

        private void batDirectionTick(object sender, EventArgs e)
        {
            game.changeBatDirection();
            batDirection.Interval = random.Next(600, 1200);

            Invalidate();
        }
    }
}
