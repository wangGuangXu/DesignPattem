using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            //工厂方法模式实现
            IFactory factory = new AddFactory();
            Operation oper=factory.createOperation();

            oper.NumA = 50;
            oper.NumB = 65;
            double result = oper.GetResult();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
