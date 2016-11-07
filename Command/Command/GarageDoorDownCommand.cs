using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class GarageDoorDownCommand : Command
    {
        GarageDoor garagedoor;
        public GarageDoorDownCommand(GarageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }
        public void execute()
        {
            garagedoor.down();
        }
        public void undo()
        {
            garagedoor.up();
        }
    }
}
