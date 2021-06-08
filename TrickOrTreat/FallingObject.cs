using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    public class FallingObject
    {
        Image image;
        Rectangle dimensions;
        public int points { get; set; }
        public int lives { get; set; }
        public bool outOfBounds { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public FallingObject(Image image, Rectangle dimensions, int points, int lives)
        {
            this.image = image;
            this.dimensions = dimensions;
            this.points = points;
            this.lives = lives;
            outOfBounds = false;
            calculateCenter();
        }

        public void draw(Graphics g)
        {
            g.DrawImage(image, dimensions);
        }

        public void move(int speed, int height)
        {
            if (dimensions.Y >= height)
                outOfBounds = true;
            else
            {
                dimensions.Y = (lives != 1) ? dimensions.Y + speed : dimensions.Y + 7 + speed;
                calculateCenter();
            }
                
        }

        private void calculateCenter()
        {
            X = dimensions.X + dimensions.Width / 2;
            Y = dimensions.Y + dimensions.Height / 2;
        }

    }
}
