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
        public Point center { get; set; }

        public FallingObject(Image image, Rectangle dimensions, int points, int lives)
        {
            this.image = image;
            this.dimensions = dimensions;
            this.points = points;
            this.lives = lives;
            outOfBounds = false;
            center = calculateCenter();
        }

        public void draw(Graphics g)
        {
            g.DrawImage(image, dimensions);
        }

        public void move(int speed, int height)
        {
            if (dimensions.Y <= 0)
                outOfBounds = true;
            else
            {
                dimensions.Y = (lives != 1) ? dimensions.Y + speed : dimensions.Y + 7 + speed;
                center = calculateCenter();
            }
                
        }

        private Point calculateCenter()
        {
            return new Point(dimensions.X + dimensions.Width / 2, dimensions.Y + dimensions.Height / 2);
        }

    }
}
