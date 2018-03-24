using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    /// <summary>
    /// 主题
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(IObserver o);
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);
        /// <summary>
        /// 通知观察者列表
        /// </summary>
        void NotifyObservers();

    }
}
