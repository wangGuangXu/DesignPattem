using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式01
{
    /// <summary>
    /// 迭代器模式 提供一种方式顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //公交车，即聚集对象
            ConcreteAggregate a = new ConcreteAggregate();

            //新上来的乘客，即对象数组
            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            //售票员正向售票()
            //Iterator i = new ConcreteIterator(a);
            //售票员反向售票
            Iterator i = new ConcreteIteratorDesc(a);

            //从第一个乘客开始
            object item = i.First();

            while (!i.IsDone())
            {
                //对面前的乘客告知请买票
                Console.WriteLine("{0} 请买车票！",i.CurrentItem());

                //下一个乘客
                i.Next();
            }

            Console.Read();
        }
    }
}
