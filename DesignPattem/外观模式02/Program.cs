using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式02
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //此时用户无需了解股票
            Fund jijin = new Fund();

            jijin.BuyFund();

            jijin.SellFund();

            Console.Read();
        }
    }
}
