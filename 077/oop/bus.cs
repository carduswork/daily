using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class bus:vehicle
    {
        public override void beep()
        {
            Console.WriteLine("bus鸣笛");
        }
    }
}
