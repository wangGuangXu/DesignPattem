using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDeparment("总公司人力资源部"));
            root.Add(new FinanceDeparment("总公司财务部"));

            ConcreteCompany comp = new ConcreteCompany("上海华东分公司");
            comp.Add(new HRDeparment("华东分公司人力资源部"));
            comp.Add(new FinanceDeparment("华东分公司财务部"));

            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("南京办事处");
            comp1.Add(new HRDeparment("南京办事处人力资源部"));
            comp1.Add(new FinanceDeparment("南京办事处财务部"));
            comp.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("杭州办事处");
            comp2.Add(new HRDeparment("杭州办事处人力资源部"));
            comp2.Add(new FinanceDeparment("杭州办事处财务部"));
            comp.Add(comp2);

            Console.WriteLine("\n 结构图：");
            root.Display(1);

            Console.WriteLine("\n 指责：");
            root.LineOfDuty();

            Console.Read();
        }
    }
}
