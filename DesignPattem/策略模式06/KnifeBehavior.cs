using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 匕首
    /// </summary>
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("使用匕首战斗");
        }
    }
}
