using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者4
{
    /// <summary>
    /// 发布委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void PublishHandle(string str);

    /// <summary>
    /// 抽象发布接口
    /// </summary>
    public interface IPublish
    {
        /// <summary>
        /// 发布事件
        /// </summary>
        event PublishHandle PublishEvent;

        /// <summary>
        /// 通知
        /// </summary>
        /// <param name="str"></param>
        void Notify(string str);
    }
}
