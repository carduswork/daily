using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.run();

            bus b = new bus();
            
        }
        public static void newv(object o)
        {
            vehicle v = o as vehicle;
            v.beep();
        }
    }
}
