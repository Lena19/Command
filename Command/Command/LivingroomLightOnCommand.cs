using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LivingroomLightOnCommand : Command
    {
        Light light;
        public LivingroomLightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
            Console.WriteLine("in the living room");
        }
        public void undo()
        {
            light.off();
            Console.WriteLine("in the living room");
        }
    }
}
