using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned:{0}",c1.Id);

            //if (p1==c1)
            //{
            //    Console.WriteLine("！=");
            //}
            Console.ReadKey();
        }
    }
}
