using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrickOrTreat
{
    public class ObjectFactory : Factory
    {
        enum TYPE { MILK, BOWL, SALMON, RAT, CHOCOLATE, SKELETON };

        private static ObjectFactory instance = null;
        private static Random random;

        private ObjectFactory()
        {
            random = new Random();
        }

        public static ObjectFactory getInstance()
        {
            if (instance == null)
                instance = new ObjectFactory();

            return instance;
        }

        public FallingObject createFallingObject(int type, int formWidth)
        {
            TYPE fallingObject = (TYPE)type;

            switch (fallingObject)
            {
                case TYPE.MILK:
                    return new FallingObject(Properties.Resources.milk_bottle,
                        new Rectangle(random.Next(1, formWidth), random.Next(-250,-10), 20, 45), 1, 0);
                case TYPE.BOWL:
                    return new FallingObject(Properties.Resources.cat_bowl,
                        new Rectangle(random.Next(1, formWidth), random.Next(-250, -10), 45, 35), 2, 0);
                case TYPE.SALMON:
                    return new FallingObject(Properties.Resources.cute_salmon,
                        new Rectangle(random.Next(1, formWidth), random.Next(-250, -10), 40, 30), 3, 0);
                case TYPE.RAT:
                    return new FallingObject(Properties.Resources.rat,
                        new Rectangle(random.Next(1, formWidth), random.Next(-250, -10), 40, 30), -1, 0);
                case TYPE.CHOCOLATE:
                    return new FallingObject(Properties.Resources.angry_chocolate,
                        new Rectangle(random.Next(1, formWidth), random.Next(-250, -10), 30, 45), -3, 0);
                case TYPE.SKELETON:
                    return new FallingObject(Properties.Resources.fish_skeleton,
                        new Rectangle(random.Next(1, formWidth), random.Next(-250, -10), 50, 25), -5, -1);
            }

            return null;
        }

        public FallingObject createExtraLife(int formWidth)
        {
            return new FallingObject(Properties.Resources.life,
                        new Rectangle(random.Next(1, formWidth), -30, 30, 30), 0, 1);
        }
    }
}
