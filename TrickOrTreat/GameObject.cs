using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrickOrTreat
{
    public class GameObject
    {
        protected Image image;
        protected Rectangle dimensions;
        public int X { get; set; }
        public int Y { get; set; }

        public GameObject(Image image, Rectangle dimensions)
        {
            this.image = image;
            this.dimensions = dimensions;
            calculateCenter();
        }

        public void draw(Graphics g)
        {
            g.DrawImage(image, dimensions);
        }
        public virtual void move(int width, int height, int speed) { }

        protected void calculateCenter()
        {
            X = dimensions.X + dimensions.Width / 2;
            Y = dimensions.Y + dimensions.Height / 2;
        }
    }
}
