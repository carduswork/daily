using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class str
    {
        static void Main()
        {
            string args = "hds_ab_lvleui";
            string[] sp = args.Split('_');
            foreach (string item in sp)
            {
                Console.WriteLine(item);
            }
            string append = "_";
            string after = string.Join(append, sp);
            Console.WriteLine(after);
            Console.ReadKey();
         }
    }
}
