using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TrickOrTreat
{
    public class Avatar : GameObject
    {
        private static Avatar instance = null;
        public bool goLeft { get; set; }
        public bool goRight { get; set; }

        private Avatar(Image image, Rectangle dimensions) : base(image,dimensions)
        {
            goLeft = false;
            goRight = false;
        }

        public static Avatar getInstance(Image image, Rectangle dimensions)
        {
            if (instance == null)
                instance = new Avatar(image,dimensions);

            return instance;
        }

        public override void move(int width, int height, int speed)
        {
            if (goLeft && dimensions.X > 0)
            {
                image = Properties.Resources.Left;
                dimensions.X -= 10;
            }
            else if (goRight && dimensions.X < width - dimensions.Width)
            {
                image = Properties.Resources.Right;
                dimensions.X += 10;       
            }

            calculateCenter();
        }

        public bool checkIntersection(FallingObject obj)
        {
            return 45 * 45 > Math.Pow(X - obj.X, 2) + Math.Pow(Y - obj.Y, 2);
        }

        public void resetInstance()
        {
            instance = null;
        }

    }
}
