using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingfan;
        public CeilingFanOffCommand(CeilingFan ceilingfan)
        {
            this.ceilingfan = ceilingfan;
        }
        public void execute()
        {
            ceilingfan.off();
        }
    }
}
