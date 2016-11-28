using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者3
{
    class Program
    {
        static void Main(string[] args)
        {
            //老板胡汉三
            BossSubject huhansan = new BossSubject();

            StockObserver tongshi1 = new StockObserver("习近平", huhansan);
            StockObserver tongshi2 = new StockObserver("李克强", huhansan);

            huhansan.Attach(tongshi1);

            huhansan.SubjectState = "我回来了";
            huhansan.Notify();

            Console.ReadKey();

        }
    }
}
