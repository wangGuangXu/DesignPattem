using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式04
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();

            Command cmd = new ConcreteCommand(r);
            Invoker invoker = new Invoker();

            invoker.SetCommand(cmd);
            invoker.ExecuteCommand();

            Console.Read();
        }
    }
}
