using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式03
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        /// <summary>
        /// 外观类 它需要了解所有的子系统的方法和属性，进行组合，以备外界调用
        /// </summary>
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n方法组A()");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n方法组B()");

            one.MethodOne();
            three.MethodThree();
        }

    }
}
