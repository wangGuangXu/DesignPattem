using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("吃过饭了吗?");
            c2.Send("没有呢，你打算请客? ");

            Console.Read();
        }
    }
}
