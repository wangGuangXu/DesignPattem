using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式02
{
    /// <summary>
    /// 中锋
    /// </summary>
    public class Center : Player
    {
        public Center(string name):base(name)
        {
            
        }

        public override void Attack()
        {
            Console.WriteLine("中锋{0}进攻",name);
        }

        public override void Defense()
        {
            Console.WriteLine("中锋{0}防守",name);
        }

    }
}
