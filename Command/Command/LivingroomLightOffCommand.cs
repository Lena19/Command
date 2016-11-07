using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LivingroomLightOffCommand : Command
    {
        Light light;
        public LivingroomLightOffCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
            Console.WriteLine("in the living room");
        }
        public void undo()
        {
            light.on();
            Console.WriteLine("in the living room");
        }
    }
}
