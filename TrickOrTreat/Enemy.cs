using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrickOrTreat
{
    public class Enemy : GameObject
    {
        private static Enemy instance = null;
        public bool goLeft { get; set; }
        public bool goRight { get; set; }
        public bool appear { get; set; }
        private Random random;

        private Enemy(Image image, Rectangle dimensions) : base(image, dimensions)
        {
            random = new Random();
            dimensions = new Rectangle(random.Next(0,490), -30, 80, 50);
            goLeft = false;
            goRight = true;
            appear = false; 
        }

        public static Enemy getInstance(Image image, Rectangle dimensions)
        {
            if (instance == null)
                instance = new Enemy(image, dimensions);

            return instance;
        }

        public new void draw(Graphics g)
        {
            if (appear)
                g.DrawImage(image, dimensions);
        }

        public new void move(int width, int height, int speed)
        {

            if (!appear)
                return;

            if (dimensions.Y + dimensions.Height < height)
                dimensions.Y += speed;
            else
            {
                dimensions.X = random.Next(0, width - dimensions.Width);
                dimensions.Y = random.Next(0, height / 2);
                appear = false;
            }
                
            if (goLeft && dimensions.X > 0)
                dimensions.X -= speed + 3;
            if (goRight && dimensions.X + dimensions.Width < width)
                dimensions.X += speed + 3;

            calculateCenter();
        }

        public bool checkIfCaught(Avatar kitty)
        {
            return 50 * 50 > Math.Pow(X - kitty.X, 2) + Math.Pow(Y - kitty.Y, 2);
        }

        public void resetInstance()
        {
            instance = null;
        }
    }
}
