using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetNGame game = new HandsetNGame();
            game.Run();

            Console.Read();
        }
    }
}
