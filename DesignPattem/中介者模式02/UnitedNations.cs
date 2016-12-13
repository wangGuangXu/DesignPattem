using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式02
{
    /// <summary>
    /// 联合国机构
    /// </summary>
    public abstract class UnitedNations
    {
        /// <summary>
        /// 声明
        /// </summary>
        /// <param name="message"></param>
        /// <param name="country"></param>
        public abstract void Declare(string message, Country country);
    }
}
