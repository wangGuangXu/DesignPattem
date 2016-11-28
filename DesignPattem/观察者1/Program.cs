using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 双向耦合的代码
             */

            //前台通知者
            Secretary tongzhizhe = new Secretary();

            //被通知者
            StockObserver tongzhi1 = new StockObserver("张三",tongzhizhe);
            StockObserver tongzhi2 = new StockObserver("李四",tongzhizhe);

            tongzhizhe.Attach(tongzhi1);
            tongzhizhe.Attach(tongzhi2);

            tongzhizhe.SecretaryState = "Boss回来了";

            tongzhizhe.Notify();

            Console.ReadKey();
        }
    }
}
