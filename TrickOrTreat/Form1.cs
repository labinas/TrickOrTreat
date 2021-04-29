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
        Random random = new Random();
        bool goLeft, goRight, batAppeared, lifeAppeared, batLeftOrRight;
        int score;
        int lives;
        int speed = 6;

        public Form1()
        {
            InitializeComponent();
            startGame();
        }

        private void collectSound()
        {
            SoundPlayer player = new SoundPlayer(TrickOrTreat.Properties.Resources.pop);
            player.Play();
        }

        private void endSound()
        {
            SoundPlayer player = new SoundPlayer(TrickOrTreat.Properties.Resources.game_over);
            player.Play();
        }

        private void adjustSpeed(int score)
        {
            if (score == 150)
                speed = 14;
            else if (score == 100)
                speed = 12;
            else if (score == 50)
                speed = 10;
            else if (score == 20)
                speed = 8;
            else if (score == 10)
                speed = 7;
        }

        private void resetPosition(PictureBox item)
        {
            item.Top = random.Next(-350, 10);
            item.Left = random.Next(0, this.ClientSize.Width - item.Width);
        }

        private void checkIntersection(PictureBox avatar, PictureBox item)
        {
            if (avatar.Bounds.IntersectsWith(item.Bounds))
            {
                if (item.Tag.Equals("-l"))
                {
                    endGame();
                }
                    
                else if (item.Tag.Equals("+l"))
                {
                    collectSound();
                    lives += 1;
                    lifeAppeared = false;
                }
                
                else
                {
                    collectSound();
                    String tag = item.Tag.ToString();
                    char sign = tag.ElementAtOrDefault(1);
                    bool parsedInt = Int32.TryParse(tag.ElementAtOrDefault(2).ToString(), out int points);
                    if (sign == '+' && parsedInt)
                        score += points;
                    else if (sign == '-')
                        score -= points;

                    if (points == 5)
                        lives--;

                }


                remainingLives.Text = lives.ToString();
                if (lives == 0)
                    endGame();

                totalScore.Text = score.ToString();
                resetPosition(item);
            }
        }

        private void gameTimerTick(object sender, EventArgs e)
        {
            adjustSpeed(score);

            foreach(Control item in this.Controls)
            {
                if(item is PictureBox)
                {
                    if(item.Tag.ToString().StartsWith("c"))
                    {
                        if (item.Location.Y + item.Height < this.ClientSize.Height)
                            item.Top += speed;
                        else
                            resetPosition((PictureBox) item);
                    }

                    if(item.Tag.ToString().Equals("-l") && batAppeared)
                    {
                        item.Top += speed;
                        if (item.Location.Y + item.Height < this.ClientSize.Height)
                        {
                            if (!batLeftOrRight && item.Left > 0)
                                item.Left -= speed+3;
                            else if (batLeftOrRight && item.Left < this.ClientSize.Width - item.Width)
                                item.Left += speed+3;
                        }   
                        else
                        {
                            resetPosition((PictureBox) item);
                            batAppeared = false;
                        }
                    }

                    if(lifeAppeared && item.Tag.Equals("+l"))
                    {
                        if (item.Location.Y + item.Height < this.ClientSize.Height)
                            item.Top += speed+7;
                        else
                        {
                            resetPosition((PictureBox)item);
                            lifeAppeared = false;
                        }
                            
                    }

                    if(!item.Tag.Equals("x") && !item.Tag.Equals("avatar"))
                        checkIntersection(kittyAvatar, (PictureBox)item);

                }
                
            }
        }

        private void moveTimerTick(object sender, EventArgs e)
        {
            if (goLeft && kittyAvatar.Left > 0)
            {
                kittyAvatar.Image = Properties.Resources.Left;
                kittyAvatar.Left -= 10;
            }
            else if (goRight && kittyAvatar.Left < this.ClientSize.Width - kittyAvatar.Width)
            {
                kittyAvatar.Image = Properties.Resources.Right;
                kittyAvatar.Left += 10;
            }
        }

        private void keyClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                goLeft = true;
            else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                goRight = true;
        }

        private void keyRelease(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                goLeft = false;
            else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                goRight = false;
        }

        private void batTimerTick(object sender, EventArgs e)
        {
            batAppeared = true;
            batTimer.Interval = random.Next(5000, 25000);
        }

        private void batMoverTick(object sender, EventArgs e)
        {
            batLeftOrRight = batLeftOrRight ? false : true;
            batMover.Interval = random.Next(600, 1200);
        }

        private void lifeTimerTick(object sender, EventArgs e)
        {
            lifeAppeared = true;
            lifeTimer.Interval = random.Next(10000, 50000);
        }

        private void startGame()
        {
            goLeft = false;
            goRight = false;
            batAppeared = false;
            batLeftOrRight = false;

            score = 0;
            totalScore.Text = score.ToString();

            lives = 3;
            remainingLives.Text = lives.ToString();

            speed = 6;

            kittyAvatar.Image = Properties.Resources.Left;
            kittyAvatar.Left = this.ClientSize.Width / 2;

            batTimer.Interval = random.Next(5000, 25000);
            lifeTimer.Interval = random.Next(10000, 50000);

            foreach(Control item in this.Controls)
            {
                if (item is PictureBox && !item.Tag.Equals("avatar") && !item.Tag.Equals("x"))
                {
                    item.Top = random.Next(-350, 10);
                    item.Left = random.Next(0, this.ClientSize.Width - item.Width);
                }
            }

            gameTimer.Start();
            moveTimer.Start();
            batTimer.Start();
            lifeTimer.Start();
            batMover.Start();
        }

        private void endGame()
        {
            endSound();
            gameTimer.Stop();
            moveTimer.Stop();
            batTimer.Stop();
            lifeTimer.Stop();
            batMover.Stop();

            DialogResult dialogResult = MessageBox.Show("Game over!" + Environment.NewLine + "Better luck next time!"
                + Environment.NewLine + "Score: " 
                + score + Environment.NewLine + "Do you want to restart the game?"
                , "GAME OVER :(", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                startGame();
            }
            else if(dialogResult == DialogResult.No)
            {
                Environment.Exit(0);
            }
        }
    }
}
