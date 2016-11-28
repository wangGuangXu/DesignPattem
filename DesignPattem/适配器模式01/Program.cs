using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.Read();
        }
    }
}
