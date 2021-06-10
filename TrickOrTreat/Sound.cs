using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreat
{
    public class Sound
    {
        private static Sound instance = null;
        private SoundPlayer collect;
        private SoundPlayer gameOver;

        private Sound()
        {
            collect = new SoundPlayer(Properties.Resources.pop);
            gameOver = new SoundPlayer(Properties.Resources.game_over);
            Game.GameOverEvent += Game_GameOverEvent;
            Game.CollectedObjectEvent += Game_CollectedObjectEvent;
        }

        private void Game_CollectedObjectEvent(object sender, EventArgs e)
        {
            collect.Play();
        }

        private void Game_GameOverEvent(object sender, EventArgs e)
        {
            gameOver.Play();
        }

        public static Sound getInstance()
        {
            if (instance == null)
                instance = new Sound();

            return instance;
        }
    }
}
