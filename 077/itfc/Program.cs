using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itfc
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoCard card = new Navida();
            
            card.convertto();
            
            card = new AMD();
            card.convertto();
            earphone card1 = new Navida();
            card1.play();
            Console.ReadKey();
        }
    }
}
