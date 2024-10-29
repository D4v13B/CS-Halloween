using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Parcial2
{
    public class Soundtrack
    {
        public Soundtrack() 
        { 
            SoundPlayer player = new SoundPlayer("C:\\Users\\Home\\Desktop\\AUDIO-SCREAM.wav");
            player.Play();
        }
    }
}
