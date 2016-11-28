using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者04
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            //指挥者用ConcreteBuilder1的方法来建造产品
            Builder builder1 = new ConcreteBuilder1();
            director.Construct(builder1);

            Product product = builder1.GetResult();
            product.Show();

            Console.Read();
        }
    }
}
