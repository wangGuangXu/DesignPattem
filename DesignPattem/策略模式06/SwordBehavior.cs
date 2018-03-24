using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 宝剑挥舞
    /// </summary>
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("使用宝剑挥舞");
        }
    }
}
