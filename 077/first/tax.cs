using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class tax
    {
        static void Main()
        {
            Console.WriteLine("输入工资");
            long income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("需交税为{0}",gettax(income));

            Console.WriteLine("判断质数100~300");
            Console.ReadKey();
            zhishu();
            Console.WriteLine("判断闰年及月份, 输入年份");
            Console.ReadKey();
            if (isrun(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("是闰年");
                Console.WriteLine("输入月份");
                int month = Convert.ToInt16(Console.ReadLine());
                if (month == 2) Console.WriteLine("29天");
                else if(month%2!=0)
                {
                    Console.WriteLine("31天");
                }
                else Console.WriteLine("30天");
            }
            else
            {
                Console.WriteLine("不是闰年");
                Console.WriteLine("输入月份");
                int month = Convert.ToInt16(Console.ReadLine());
                if (month == 2) Console.WriteLine("28天");
                else if (month % 2 == 0)              
                    Console.WriteLine("31天");           
                else Console.WriteLine("30天");
            }
            Console.ReadKey();
        }
        private static float gettax(long income)
        {
            if (income>=1600)
            {
                return (float)(income * 0.1);
            }
            else
            {
                return income;
            }
        }
        private static void zhishu()
        {
            for (int i =100 ; i <=300; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        break;
                    }
                    else if(j==i-1&&i%j!=0)
                    {
                        Console.WriteLine("{0}是质数", i);
                        continue;
                    }
                }
                
            }
        }
        private static bool isrun(int year)
        {
            if (year<=400)
            {
                if (year % 4 == 0 && year % 100 != 0)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
