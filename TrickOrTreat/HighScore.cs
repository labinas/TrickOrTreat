using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    [Serializable]
    public class HighScore
    {
        public int highScore { get; set; } = 0;

        public HighScore()
        {
            highScore = 0;
        }
    }
}
