using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式实现
            Console.WriteLine("请输入数字A:");
            string numA = Console.ReadLine();

            Console.WriteLine("请输入数字B");
            string numB = Console.ReadLine();

            Console.WriteLine("请输入运算符号：");
            string strOperation = Console.ReadLine();

            Operation oper = OperationFactory.CreateOperate(strOperation);

            oper.NumA = double.Parse(numA);
            oper.NumB = double.Parse(numB);

            double result = oper.GetResult();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
