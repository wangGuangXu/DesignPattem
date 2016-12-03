using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式03
{
    class Program
    {
        static void Main(string[] args)
        {
            //开店前的准备
            Barbecuer boy = new Barbecuer();

            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);

            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);

            //服务员
            Waiter gir1 = new Waiter();

            //开门营业 顾客点菜
            gir1.SetOrder(bakeMuttonCommand1);
            gir1.SetOrder(bakeMuttonCommand2);
            gir1.SetOrder(bakeChickenWingCommand1);

            //点菜完毕，通知厨房
            gir1.Notify();

            Console.Read();
        }
    }
}
