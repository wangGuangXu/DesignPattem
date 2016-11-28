using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者4
{
    /// <summary>
    /// 订阅者
    /// </summary>
    public class Subscriber
    {
        /// <summary>
        /// 订阅者名称
        /// </summary>
        private string _subscriberName;
        /// <summary>
        /// 订阅者
        /// </summary>
        /// <param name="subscriberName">订阅者名称</param>
        public Subscriber(string subscriberName)
        {
            this._subscriberName = subscriberName;
        }

        private void Show(string str)
        {
            Console.WriteLine(string.Format("我是{0},收到订阅的{1}",_subscriberName,str));
        }

        public ISubscribe AddSubscribe { set { value.SubscribeEvent += Show; } }
        public ISubscribe RemoveSubscribe { set { value.SubscribeEvent -= Show; } }

    }
}
