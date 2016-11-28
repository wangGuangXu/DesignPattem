using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂01
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
            
            //简单的界面于业务逻辑分离
            double result=Operation.GetResult(double.Parse(numA),double.Parse(numB),operation);
            Console.WriteLine("结果为："+result.ToString());

            Console.ReadKey();
        }
    }
}
