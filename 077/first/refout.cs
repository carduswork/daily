using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class refout
    {
        static void Main()
        {
            Console.WriteLine("输入半径");
            double c=0;
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("面积为{0},周长为{1}",getthetwo(r, ref c), c);
            Console.ReadKey();
        }
        private static double getthetwo(double r, ref double c)
        {//周长
            c=2*3.14*r;
            //面积
            return 3.14 * r * r;
        }
    }
}
