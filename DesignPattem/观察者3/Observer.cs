using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者3
{
    /// <summary>
    /// 抽象观察者类
    /// </summary>
    public abstract class Observer
    {
        protected string name;
        protected ISubject sub;//抽象通知者

        public Observer(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
        

    }
}
