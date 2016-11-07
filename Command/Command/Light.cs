using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Light
    {
        public void on()
        {
            Console.WriteLine("The light was on");
        }
        public void off()
        {
            Console.WriteLine("The light was off");
        }
    }
}
