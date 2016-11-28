using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者4
{
    /// <summary>
    /// 具体发布者
    /// </summary>
    public class Publisher:IPublish
    {
        /// <summary>
        /// 发布者名称
        /// </summary>
        private string _publisherName;
        /// <summary>
        /// 发布者
        /// </summary>
        /// <param name="publisherName">发布者名称</param>
        public Publisher(string publisherName)
        {
            this._publisherName = publisherName;
        }

        private event PublishHandle publishEvent;
        public event PublishHandle PublishEvent
        {
            add { publishEvent += value; }
            remove { publishEvent -= value; }
        }

        public void Notify(string str)
        {
            if (publishEvent!=null)
            {
                publishEvent.Invoke(string.Format("由{0}---发布{1}", _publisherName, str));
            }
        }

    }
}
