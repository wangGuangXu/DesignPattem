using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式01
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        /// <summary>
        /// 用于定义得到开始对象，得到下一个对象 判断是否到结尾、当前对象等抽象方法，统一接口
        /// </summary>
        /// <returns></returns>
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
