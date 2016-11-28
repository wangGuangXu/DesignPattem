using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式03
{
    /// <summary>
    /// 抽象模板类
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// 抽象行为放到子类去实现
        /// </summary>
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        /// <summary>
        /// 模板方法
        /// 给出了逻辑的骨架，而逻辑的组成是一些相应的抽象操作，它们推迟到了子类去实现
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }


    }
}
