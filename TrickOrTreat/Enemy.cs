using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrickOrTreat
{
    public class Enemy
    {
        private static Enemy instance = null;
        private Image image;
        private Rectangle dimensions;
        public Point center { get; set; }
        public bool goLeft { get; set; }
        public bool goRight { get; set; }
        public bool appear { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private Random random;

        private Enemy()
        {
            random = new Random();
            image = Properties.Resources.bat_enemy;
            dimensions = new Rectangle(random.Next(0,490), -30, 80, 50);
            calculateCenter();
            goLeft = false;
            goRight = true;
            appear = false; 
        }

        public static Enemy getInstance()
        {
            if (instance == null)
                instance = new Enemy();

            return instance;
        }

        public void draw(Graphics g)
        {
            if (appear)
                g.DrawImage(image, dimensions);
        }

        public void move(int formWidth, int formHeight, int speed)
        {

            if (!appear)
                return;

            if (dimensions.Y + dimensions.Height < formHeight)
                dimensions.Y += speed;
            else
            {
                dimensions.X = random.Next(0, formWidth - dimensions.Width);
                dimensions.Y = random.Next(0, formHeight / 2);
                appear = false;
            }
                
            if (goLeft && dimensions.X > 0)
                dimensions.X -= speed + 3;
            if (goRight && dimensions.X + dimensions.Width < formWidth)
                dimensions.X += speed + 3;

            calculateCenter();
        }

        public bool checkIfCaught(Avatar kitty)
        {
            return 45 * 45 > Math.Pow(X - kitty.X, 2) + Math.Pow(Y - kitty.Y, 2);
        }

        private void calculateCenter()
        {
            X = dimensions.X + dimensions.Width / 2;
            Y = dimensions.Y + dimensions.Height / 2;
        }

        public void reset()
        {
            dimensions = new Rectangle(random.Next(0, 490), -30, 80, 50);
            appear = false;
            calculateCenter();
        }
    }
}
