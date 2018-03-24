using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 骑士
    /// </summary>
    public class Knight : Character
    {
        /// <summary>
        /// 骑士默认采用弓箭战斗
        /// </summary>
        public Knight()
        {
            weapon = new BowAndArrowBehavior();
        }

        /// <summary>
        /// 骑士战斗
        /// </summary>
        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
