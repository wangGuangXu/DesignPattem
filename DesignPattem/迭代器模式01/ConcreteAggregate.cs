using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式01
{
    /// <summary>
    /// 具体聚集类
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<Object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// 返回聚集总个数
        /// </summary>
        public int Count
        {
            get { return items.Count; }
        }

        /// <summary>
        /// 声明一个索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
