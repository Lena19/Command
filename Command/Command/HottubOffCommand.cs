using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class HottubOffCommand : Command
    {
        Hottub hottub;
        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void execute()
        {
            hottub.off();
        }
    }
}
