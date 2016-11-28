using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式03
{
    /// <summary>
    /// 子系统1
    /// </summary>
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }

    /// <summary>
    /// 子系统2
    /// </summary>
    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }

    /// <summary>
    /// 子系统3
    /// </summary>
    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }

    /// <summary>
    /// 子系统4
    /// </summary>
    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法四");
        }
    }
}
