using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式01
{
    /// <summary>
    /// N品牌的手机中的游戏
    /// </summary>
    public class HandsetNGame:HandsetGame
    {
        public override void Run()
        {
            Console.WriteLine("运行N 品牌手机游戏");
        }
    }
}
