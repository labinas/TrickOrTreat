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
        private Random random;

        private Enemy()
        {
            random = new Random();
            image = Properties.Resources.bat_enemy;
            dimensions = new Rectangle(-30, -30, 80, 50);
            center = calculateCenter();
            goLeft = false;
            goRight = false;
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

            center = calculateCenter();
        }

        public bool checkIfCaught(Avatar kitty)
        {
            return 45 * 45 > Math.Pow(center.X - kitty.center.X, 2) + Math.Pow(center.Y - kitty.center.Y, 2);
        }

        private Point calculateCenter()
        {
            return new Point(dimensions.X + dimensions.Width / 2, dimensions.Y + dimensions.Height / 2);
        }
    }
}
