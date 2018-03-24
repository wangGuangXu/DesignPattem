using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    /// <summary>
    /// 武器行为接口
    /// </summary>
    public interface IWeaponBehavior
    {
        /// <summary>
        /// 使用武器
        /// </summary>
        void UseWeapon();

    }
}
