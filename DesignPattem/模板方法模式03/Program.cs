using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式03
{
    class Program
    {
        /// <summary>
        /// 客户端调用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.Read();

        }
    }
}
