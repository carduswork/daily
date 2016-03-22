using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class _251
    {
        static void Main()
        {
            Console.WriteLine("输入url地址：");
            string url = Console.ReadLine();
            Console.WriteLine("网站类型{0}",gettype(url));
            Console.WriteLine("协议{0}",getpro(url));
            Console.ReadKey();

        }
        private static string gettype(string url){
            int index = url.LastIndexOf('.');       
            string sub = url.Substring(index+1);
            switch (sub)
            {
                case "com": return"商务";
                case "net": return "服务"; 
                case "org": return "非盈利";
                case "gov": return "政府";
                case "edu": return "教育";
                default: return null;
                    
            }
        }
        private static string getpro(string  url)
        {
            int index = url.IndexOf(':');
            string sub = url.Substring(0, index);
            switch (sub)
            {
                case "http": return "http";
                case "ftp": return "ftp";
                //case "org": return "非盈利; break;
                //case "gov": return "政府"; ; break
                //case "edu": return "教育"; break;
                default: return "未知";
                    
            }
        }
    }
}
