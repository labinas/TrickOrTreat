using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    public class Game
    {
        private ObjectFactory factory;
        Avatar avatar;
        Enemy enemy;
        List<FallingObject> fallingObjects;
        Sound sound;
        int formWidth;
        int formHeight;
        public int totalScore { get; set; }
        public int totalLives { get; set; }
        public int speed { get; set; }
        private int factor;
        Random random;
        public bool gameOver;

        public Game(int width, int height)
        {
            factory = ObjectFactory.getInstance();
            formWidth = width;
            formHeight = height;
            fallingObjects = new List<FallingObject>();
            avatar = Avatar.getInstance(formWidth, formHeight);
            enemy = Enemy.getInstance();
            sound = Sound.getInstance();
            totalScore = 0;
            totalLives = 3;
            speed = 6;
            factor = 10;
            gameOver = false;
            random = new Random();
        }

        public void draw(Graphics g)
        {
            enemy.draw(g);
            foreach(FallingObject obj in fallingObjects)
            {
                obj.draw(g);
            }
        }

        public void move()
        {
            avatar.move();
            enemy.move(formWidth, formHeight, speed);

            foreach(FallingObject obj in fallingObjects)
            {
                obj.move(speed, formHeight);
            }

            update();
        }

        public void generateObjects()
        {
            fallingObjects.Add(factory.createFallingObject(random.Next(6), formWidth));
        }

        public void generateExtraLife()
        {
            fallingObjects.Add(factory.createExtraLife(formWidth));
        }

        private void update()
        {
            adjustSpeed();

            if (enemy.checkIfCaught(avatar) || totalLives == 0)
            {
                gameOver = true;
                sound.playGameOverSound();
            }

            else
            {
                for(int i = fallingObjects.Count -1; i >= 0; i--)
                {
                    if (avatar.checkIntersection(fallingObjects[i]))
                    {
                        sound.playCollectSound();
                        totalScore += fallingObjects[i].points;
                        totalLives += fallingObjects[i].lives;
                        fallingObjects.RemoveAt(i);
                    }

                    if (fallingObjects[i].outOfBounds)
                        fallingObjects.RemoveAt(i);
                }
            }
        }

        private void adjustSpeed()
        {
            if(totalScore >= factor)
            {   
                if (factor <= 20)
                    speed += 1;
                else
                    speed += 2;
                factor = factor * 2;
            }
        }

        public void adjustAvatarsLeft(bool value)
        {
            avatar.goLeft = value;
        }

        public void adjustAvatarsRight(bool value)
        {
            avatar.goRight = value;
        }

        public void makeBatAppear()
        {
            enemy.appear = true;
        }

        public void changeBatDirection()
        {
            if (enemy.goLeft)
            {
                enemy.goLeft = false;
                enemy.goRight = true;
            }
            else
            {
                enemy.goRight = false;
                enemy.goLeft = true;
            }
        }

        public Avatar getAvatar()
        {
            return avatar;
        }
    }
}
