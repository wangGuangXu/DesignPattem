using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式01
{
    /// <summary>
    /// 从后向前的迭代
    /// </summary>
    public class ConcreteIteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }


        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if (current>=0)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
