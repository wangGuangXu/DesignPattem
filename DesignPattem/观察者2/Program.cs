using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者2
{
    class Program
    {
        static void Main(string[] args)
        {
            //观察者(前台)
            Secretary tongzhizhe = new Secretary();

            //员工(被通知的对象)
            Observer tongzhiNBA = new NBAObserver("张三", tongzhizhe);
            Observer tongzhiStock = new StockObserver("李四", tongzhizhe);
            
            tongzhizhe.Attach(tongzhiNBA);
            tongzhizhe.Attach(tongzhiStock);

            tongzhizhe.SecretaryState = "老板回来了";
            tongzhizhe.Notify();

            Console.ReadKey();

        }
    }
}
