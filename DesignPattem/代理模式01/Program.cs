using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mm = new SchoolGirl();
            mm.Name = "abcde";

            Proxy proxy = new Proxy(mm);

            proxy.GiveDolls();
            proxy.GiveFlowers();
            proxy.GiveChocolate();

            Console.ReadKey();

        }
    }
}
