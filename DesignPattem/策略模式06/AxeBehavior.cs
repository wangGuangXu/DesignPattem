using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 斧头砍劈
    /// </summary>
    public class AxeBehavior : IWeaponBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        public void UseWeapon()
        {
            Console.WriteLine("使用斧头劈砍");
        }
    }
}
