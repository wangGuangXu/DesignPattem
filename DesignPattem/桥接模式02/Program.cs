using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand ab;

            ab = new HandsetBrandMAddressList();
            ab.Run();




            Console.Read();
        }
    }
}
