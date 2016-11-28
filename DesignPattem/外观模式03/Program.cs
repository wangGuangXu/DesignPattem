using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式03
{
    /// <summary>
    /// 外观模式： 为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口,这个接口使得这一子系统更加容易使用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //由于外观类的作用，客户端可以根本不知道三个子系统类的存在
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.Read();

        }
    }
}
