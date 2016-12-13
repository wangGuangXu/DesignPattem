using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式01
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }


    }
}
