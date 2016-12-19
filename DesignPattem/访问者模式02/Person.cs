using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式02
{
    /// <summary>
    /// 人类
    /// </summary>
    public abstract class Person
    {

        /// <summary>
        /// 接受
        /// </summary>
        /// <param name="visitor">用来获得状态对象的</param>
        public abstract void Accept(Action visitor);
    }
}
