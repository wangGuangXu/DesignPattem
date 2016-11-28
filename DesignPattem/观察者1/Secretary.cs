using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者1
{
    /// <summary>
    /// 秘书类
    /// </summary>
    public class Secretary
    {
        //观察者(同事)列表
        private IList<StockObserver> observers = new List<StockObserver>();

        /// <summary>
        /// 前台状态
        /// </summary>
        public string SecretaryState { get; set; }

        /// <summary>
        /// 追加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(StockObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}