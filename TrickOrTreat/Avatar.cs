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
        public PictureBox kittyAvatar { get; set; }
        private int formWidth;
        private int formHeight;
        public bool goLeft { get; set; }
        public bool goRight { get; set; }
        public Point center { get; set; }

        private Avatar(int width, int height)
        {
            formWidth = width;
            formHeight = height;
            kittyAvatar = new PictureBox();
            kittyAvatar.Image = Properties.Resources.Left;
            kittyAvatar.Size = new Size(85, 85);
            kittyAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            kittyAvatar.Location = new Point(230, 635);
            //kittyAvatar.Location = new Point(formWidth / 2 - kittyAvatar.Left / 2, formHeight - kittyAvatar.Top);
            kittyAvatar.BackColor = Color.Transparent;
            goLeft = false;
            goRight = false;
            center = calculateCenter();
        }

        public static Avatar getInstance(int width, int height)
        {
            if (instance == null)
                instance = new Avatar(width, height);

            return instance;
        }

        public void move()
        {
            if (goLeft && kittyAvatar.Left > 0)
            {
                kittyAvatar.Image = Properties.Resources.Left;
                kittyAvatar.Left -= 10;
                center = calculateCenter();
            }
            else if (goRight && kittyAvatar.Left < formWidth - kittyAvatar.Width)
            {
                kittyAvatar.Image = Properties.Resources.Right;
                kittyAvatar.Left += 10;
                center = calculateCenter();
            }
        }

        public bool checkIntersection(FallingObject obj)
        {
            return 45 * 45 > Math.Pow(center.X - obj.center.X, 2) + Math.Pow(center.Y - obj.center.Y, 2);
        }

        private Point calculateCenter()
        {
            return new Point(kittyAvatar.Left + kittyAvatar.Width / 2, kittyAvatar.Top + kittyAvatar.Height / 2);
        }
    }
}
