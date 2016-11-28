using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者2
{
    /// <summary>
    /// 秘书类
    /// </summary>
    public class Secretary
    {
        //观察者(同事)列表
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 前台状态
        /// </summary>
        public string SecretaryState { get; set; }

        /// <summary>
        /// 追加观察者
        /// </summary>
        /// <param name="observer">针对抽象编程,减少了于具体类的耦合</param>
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
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