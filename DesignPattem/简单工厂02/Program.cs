using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字A:");
            string numA = Console.ReadLine();

            Console.WriteLine("请输入数字B：");
            string numB = Console.ReadLine();

            Console.WriteLine("请输入运算符：");
            string operation = Console.ReadLine();

            Operation oper = new Operation();
            oper = OperationFactory.createOperation("+");

            oper.NumA=double.Parse(numA);
            oper.NumB=double.Parse(numB);
            
            //简单的界面于业务逻辑分离
            double result = oper.GetResult();

            Console.WriteLine("结果为："+result);
            Console.ReadKey();
        }
    }
}
