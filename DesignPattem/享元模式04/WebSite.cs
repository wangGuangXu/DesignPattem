using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式04
{
    /// <summary>
    /// 网站抽象类
    /// </summary>
    public abstract class WebSite
    {
        /// <summary>
        /// 使用
        /// </summary>
        public abstract void Use(User user);
    }
}
