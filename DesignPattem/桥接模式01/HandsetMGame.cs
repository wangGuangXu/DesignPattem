using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式01
{
    /// <summary>
    /// M品牌手机游戏
    /// </summary>
    public class HandsetMGame:HandsetGame
    {
        public override void Run()
        {
            Console.WriteLine("运行M品牌手机游戏");
        }
    }
}
