using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者4
{
    /// <summary>
    /// 订阅委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void SubscribeHandle(string str);

    /// <summary>
    /// 抽象订阅接口
    /// </summary>
    public interface ISubscribe
    {
        /// <summary>
        /// 订阅事件
        /// </summary>
        event SubscribeHandle SubscribeEvent;
    }
}
