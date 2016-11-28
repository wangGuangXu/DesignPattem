using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式03
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类B 方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B 方法2实现");
        }
    }
}
