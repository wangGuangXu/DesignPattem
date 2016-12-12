using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] reqeuests = { 2,5,14,22,18,3,27,20};
            foreach (var item in reqeuests)
            {
                h1.HandleRequest(item);
            }

            Console.Read();
        }
    }
}
