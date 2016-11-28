using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式01
{
    /// <summary>
    /// 装饰模式：动态的给一个对象添加一些额外的职责,就增加功能来说装饰模式比生成子类更为灵活。
    /// 装饰模式的特点：把类中的功能从类中搬移去除,这样可以简化原有的类。
    /// 优点：可以有效地把类的核心职责和装饰功能区分开了,而且可以去除相关类中重复的装饰逻辑
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小菜");
            Console.WriteLine("第一种装饰\n");

            TShirts dtx = new TShirts();
            BigTrouser kk = new BigTrouser();

            dtx.Decorate(person);
            kk.Decorate(dtx);
            kk.Show();

            Person zs = new Person("张三");
            Console.WriteLine("\n第二种装饰\n");

            BigTrouser bt = new BigTrouser();
            TShirts ts = new TShirts();

            bt.Decorate(zs);
            ts.Decorate(bt);
            ts.Show();

            Console.ReadKey();
        }
    }
}
