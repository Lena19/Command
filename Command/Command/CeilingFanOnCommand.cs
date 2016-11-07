using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CeilingFanOnCommand : Command
    {
        CeilingFan ceilingfan;
        public CeilingFanOnCommand(CeilingFan ceilingfan)
        {
            this.ceilingfan = ceilingfan;
        }
        public void execute()
        {
            ceilingfan.on();
        }
    }
}
