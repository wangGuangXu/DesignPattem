using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者4
{
    /// <summary>
    /// 具体订阅器
    /// </summary>
    public class SubPubComponet : ISubscribe, IPublish
    {
        private string _subName;
        public SubPubComponet(string subName)
        {
            this._subName = subName;
            publishEvent += new PublishHandle(Notify);
        }

        private event SubscribeHandle subscribeEvent;
        public event SubscribeHandle SubscribeEvent
        {
            add { subscribeEvent += value; }
            remove { subscribeEvent -= value; }
        }

        private event PublishHandle publishEvent;
        public event PublishHandle PublishEvent
        {
            add { publishEvent += value; }
            remove { publishEvent -= value; }
        }

        public void Notify(string str)
        {
            if (subscribeEvent != null)
            {
                subscribeEvent.Invoke(string.Format("消息来源{0}，消息内容:{1}", _subName, str));
            }
        }

    }
}
