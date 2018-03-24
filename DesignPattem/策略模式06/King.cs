using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 国王
    /// </summary>
    public class King : Character
    {
        /// <summary>
        /// 国王默认采用宝剑战斗
        /// </summary>
        public King()
        {
            weapon = new SwordBehavior();
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
