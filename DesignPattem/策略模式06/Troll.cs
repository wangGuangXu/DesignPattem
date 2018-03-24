using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 怪物
    /// </summary>
    public class Troll : Character
    {
        /// <summary>
        /// 怪物默认采用斧头砍劈
        /// </summary>
        public Troll()
        {
            weapon = new AxeBehavior();
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
