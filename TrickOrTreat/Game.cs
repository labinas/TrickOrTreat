using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrickOrTreat
{

    public class Game
    {
        public event EventHandler EndEvent;
        public static event EventHandler GameOverEvent;
        public static event EventHandler CollectedObjectEvent;
        public static Game instance = null;

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

        private Game(int width, int height)
        {
            factory = ObjectFactory.getInstance();
            formWidth = width;
            formHeight = height;
            fallingObjects = new List<FallingObject>();
            avatar = factory.createAvatar(formWidth,formHeight);
            enemy = factory.createEnemy(formWidth,formHeight);
            sound = Sound.getInstance();
            totalScore = 0;
            totalLives = 3;
            speed = 8;
            factor = 10;
            gameOver = false;
            random = new Random();
        }

        public static Game getInstance(int width, int height)
        {
            if (instance == null)
                instance = new Game(width, height);

            return instance;
        }

        public void draw(Graphics g)
        {
            avatar.draw(g);
            enemy.draw(g);
            foreach(FallingObject obj in fallingObjects)
            {
                obj.draw(g);
            }
        }

        public void move()
        {       
            avatar.move(formWidth, formHeight, speed);     
            enemy.move(formWidth, formHeight, speed);

            foreach(FallingObject obj in fallingObjects)
            {
                obj.move(formWidth, formHeight, speed);
            }

            update();
        }

        public void generateObjects()
        {
            fallingObjects.Add((FallingObject) factory.createObject(random.Next(6), formWidth, formHeight));
        }

        public void generateExtraLife()
        {
            fallingObjects.Add(factory.createExtraLife(formWidth, formHeight));
        }

        private void update()
        {
            adjustSpeed();

            if (enemy.checkIfCaught(avatar) || totalLives == 0)
            {
                if (GameOverEvent != null)
                   GameOverEvent.Invoke(this, EventArgs.Empty);
                if (EndEvent != null)
                    EndEvent.Invoke(this, EventArgs.Empty);               
            }

            else
            {
                for(int i = fallingObjects.Count -1; i >= 0; i--)
                {
                    if (avatar.checkIntersection(fallingObjects[i]))
                    {
                        if (CollectedObjectEvent != null)
                            CollectedObjectEvent.Invoke(this, EventArgs.Empty);

                        totalScore += fallingObjects[i].points;
                        totalLives += fallingObjects[i].lives;
                        fallingObjects.RemoveAt(i);
                    }

                    else if (fallingObjects[i].outOfBounds)
                        fallingObjects.RemoveAt(i);
                }
            }
        }

        private void adjustSpeed()
        {
            if(totalScore >= factor)
            {   
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

        public void resetGame()
        {
            avatar.resetInstance();
            enemy.resetInstance();
            instance = null;
        }

        public int getFallingObjectsCount()
        {
            return fallingObjects.Count;
        }
    }
}
