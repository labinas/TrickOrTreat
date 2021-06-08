using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TrickOrTreat
{
    public class Avatar
    {
        private static Avatar instance = null;
        Image kittyAvatar;
        Rectangle dimensions;
        private int formWidth;
        private int formHeight;
        public bool goLeft { get; set; }
        public bool goRight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private Avatar(int width, int height)
        {
            formWidth = width;
            formHeight = height;
            kittyAvatar = Properties.Resources.Left;
            dimensions = new Rectangle(formWidth / 2 - 85 / 2, formHeight - 85, 85, 85);
            goLeft = false;
            goRight = false;
            calculateCenter();
        }

        public static Avatar getInstance(int width, int height)
        {
            if (instance == null)
                instance = new Avatar(width, height);

            return instance;
        }

        public void draw(Graphics g)
        {
            g.DrawImage(kittyAvatar, dimensions);
        }

        public void move()
        {
            if (goLeft && dimensions.X > 0)
            {
                kittyAvatar = Properties.Resources.Left;
                dimensions.X -= 10;
            }
            else if (goRight && dimensions.X < formWidth - dimensions.Width)
            {
                kittyAvatar = Properties.Resources.Right;
                dimensions.X += 10;       
            }

            calculateCenter();
        }

        public bool checkIntersection(FallingObject obj)
        {
            return 45 * 45 > Math.Pow(X - obj.X, 2) + Math.Pow(Y - obj.Y, 2);
        }

        private void calculateCenter()
        {
            X = dimensions.X + dimensions.Width / 2;
            Y = dimensions.Y + dimensions.Height / 2;
        }

        public void reset()
        {
            dimensions = new Rectangle(formWidth / 2 - 85 / 2, formHeight - 85, 85, 85);
            goLeft = false;
            goRight = false;
            calculateCenter();
        }
    }
}
