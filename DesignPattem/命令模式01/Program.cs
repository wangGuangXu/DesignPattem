using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式01
{
    /// <summary>
    /// 紧耦合设计
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //客户端程序与烤肉者紧耦合，尽管简单,但却极为僵化，有许多隐患

            Barbecuer boy = new Barbecuer();

            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();

            boy.BakeChickenWing();
            boy.BakeMutton();
            boy.BakeMutton();

            boy.BakeChickenWing();


            Console.Read();
        }
    }
}
