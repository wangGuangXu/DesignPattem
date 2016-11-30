using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式03
{
    /// <summary>
    /// 手机MP3播放器
    /// </summary>
    public class HandsetMP3 : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机MP3播放");
        }
    }
}
