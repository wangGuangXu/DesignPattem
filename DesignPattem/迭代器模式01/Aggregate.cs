using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式01
{
    /// <summary>
    /// 聚集抽象类
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// 创建迭代器
        /// </summary>
        /// <returns></returns>
        public abstract Iterator CreateIterator();
    }
}
