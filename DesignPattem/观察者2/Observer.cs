using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者2
{
    /// <summary>
    /// 抽象观察者类
    /// </summary>
    public abstract class Observer
    {
        protected string name;
        protected Secretary sub;

        public Observer(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
        

    }
}
