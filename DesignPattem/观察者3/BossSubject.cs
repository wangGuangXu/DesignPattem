using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者3
{
    /// <summary>
    /// 老板(具体通知者)
    /// </summary>
    public class BossSubject : ISubject
    {
        //观察者(同事)列表
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 前台状态
        /// </summary>
        public string SubjectState { get; set; }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
