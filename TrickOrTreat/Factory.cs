using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    public interface Factory
    {
        FallingObject createFallingObject(int type, int formWidth);
        FallingObject createExtraLife(int formWidth);
    }
}
