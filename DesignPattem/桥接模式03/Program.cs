using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式03
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand ab;

            //诺基亚手机
            ab = new HandsetBrandN();

            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            ab.SetHandsetSoft(new HandsetMP3());
            ab.Run();

            Console.WriteLine(" \r\n");

            //摩托罗拉手机
            ab = new HandsetBrandM();

            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            ab.SetHandsetSoft(new HandsetMP3());
            ab.Run();

            Console.Read();
        }
    }
}
