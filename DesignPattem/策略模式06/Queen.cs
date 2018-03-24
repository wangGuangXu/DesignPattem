using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 皇后
    /// </summary>
    public class Queen : Character
    {
        /// <summary>
        /// 皇后默认使用匕首战斗
        /// </summary>
        public Queen()
        {
            weapon = new KnifeBehavior();
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
