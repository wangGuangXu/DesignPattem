using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式02
{
    /// <summary>
    /// 音速
    /// </summary>
    public class Speed : Expression
    {
        public override void Excute(string key, double value)
        {
            string speed;
            if (value < 500)
            {
                speed = "快速";
            }
            else if (value >= 1000)
            {
                speed = "慢速";
            }
            else {
                speed = "中速";
            }

            Console.WriteLine("{0}",speed);
        }
    }
}
