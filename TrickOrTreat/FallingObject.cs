using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    public class FallingObject : GameObject
    {
        public int points { get; set; }
        public int lives { get; set; }
        public bool outOfBounds { get; set; }

        public FallingObject(Image image, Rectangle dimensions, int points, int lives) : base(image,dimensions)
        {
            this.points = points;
            this.lives = lives;
            outOfBounds = false;
        }

        public override void move(int width, int height, int speed)
        {
            if (dimensions.Y >= height)
                outOfBounds = true;
            else
            {
                dimensions.Y = (lives != 1) ? dimensions.Y + speed : dimensions.Y + 7 + speed;
                calculateCenter();
            }

        }

    }
}
