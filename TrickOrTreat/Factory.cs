using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    public interface Factory
    {
        GameObject createObject(int type, int formWidth, int formHeight);
        FallingObject createExtraLife(int formWidth, int formHeight);
        Avatar createAvatar(int formWidth, int formHeight);
        Enemy createEnemy(int formWidth, int formHeight);

    }
}
