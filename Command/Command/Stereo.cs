using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Stereo
    {
        public void on()
        {
            Console.WriteLine("Stereo is on");
        }
        public void setCD()
        {
            Console.WriteLine("CD is set");
        }
        public void setVolume(int volume)
        {
            Console.WriteLine("Volume is set on the level " + volume);
        }
        public void off()
        {
            Console.WriteLine("Stereo is off");
        }
    }
}
