using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 抽象角色
    /// </summary>
    public abstract class Character
    {
        public IWeaponBehavior weapon;

        /// <summary>
        /// 动态设置对象
        /// </summary>
        /// <param name="w"></param>
        public void SetWeapon(IWeaponBehavior w)
        {
            Console.WriteLine("\r\n更换武器");
            this.weapon = w;
        }

        /// <summary>
        /// 战斗
        /// </summary>
        public abstract void Fight();
    }
}
