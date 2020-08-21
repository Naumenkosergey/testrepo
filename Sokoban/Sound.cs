using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Sokoban
{
    class Sound
    {
        static SoundPlayer moveSound =
            new SoundPlayer(Properties.Resources.click);
        static SoundPlayer victorySound =
            new SoundPlayer(Properties.Resources.victory);
        private static bool flagMoveSound = true;

        public static void MoveSoundPlay()
        {
            if (flagMoveSound)
                moveSound.Play();
        }
        public static void MoveSoundStop()
        {
            if (flagMoveSound)
                moveSound.Stop();
        }

        internal static void MoveSoundPlayON()
        {
            flagMoveSound = true;
        }

        internal static void MoveSoundPlayOFF()
        {
            flagMoveSound = false;
        }

        internal static void VictorySoundPlay()
        {
            if (flagMoveSound)
                victorySound.Play();
        }
    }
}
