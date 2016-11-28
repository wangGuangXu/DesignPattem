using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock1 gu1 = new Stock1();
            Stock1 gu2 = new Stock1();
            Stock1 gu3 = new Stock1();

            NationalDebt1 nd1 = new NationalDebt1();
            Retalty1 rt1 = new Retalty1();

            gu1.Buy();
            gu2.Buy();
            gu3.Buy();

            nd1.Buy();
            rt1.Buy();


            gu1.Sell();
            gu2.Sell();
            gu3.Sell();

            nd1.Sell();
            rt1.Sell();

            Console.ReadKey();
        }
    }
}
