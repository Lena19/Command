using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class GarageDoorUpCommand : Command
    {
        GarageDoor garagedoor;
        public GarageDoorUpCommand(GarageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }
        public void execute()
        {
            garagedoor.up();
        }
        public void undo()
        {
            garagedoor.down();
        }
    }
}
