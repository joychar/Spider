using Spider.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSpider
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = new Domain().InsertDomain("www.baidu.com1", "baidu 1");

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
