using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class pascal
    {
        static void Main()
        {
            Console.WriteLine("输入一句话");
            string arg = Console.ReadLine();
            string order="n";

            do
            {
                topascal(ref arg);
                Console.WriteLine(arg);
                Console.WriteLine("是否继续（Y/N）");
                order = Console.ReadLine();
            } while (order.ToLower() == "n");
            Console.ReadKey();
        }
        private static void topascal(ref string arg)
        {
            string[] sp =arg.Split(' ');
            string buffer1,buffer2;
            string[] pas = new string[sp.Length];
            for (int i = 0; i < sp.Length; i++)
            {
                //sp.Replace(sp[i].Substring(0, 1), sp[i].Substring(0, 1).ToUpper());
                buffer1 = sp[i].Substring(0, 1).ToUpper();
                buffer2=sp[i].Substring(1);
                buffer1 += buffer2;
                pas[i] = buffer1;
            }
            
             arg = string.Join("",pas);
        }
    }
}
