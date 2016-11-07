using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class HottubOnCommand : Command
    {
        Hottub hottub;
        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void execute()
        {
            hottub.on();
        }
        public void undo()
        {
            hottub.off();
        }
    }
}
