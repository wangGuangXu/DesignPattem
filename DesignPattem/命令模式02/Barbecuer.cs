using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式02
{
    /// <summary>
    /// 烤肉串者
    /// </summary>
    public class Barbecuer
    {
        /// <summary>
        /// 烤羊肉串
        /// </summary>
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串！");
        }

        /// <summary>
        /// 烤鸡翅
        /// </summary>
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅！");
        }
    }
}
