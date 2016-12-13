using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式01
{
    /// <summary>
    /// 具体中介者
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;

        /// <summary>
        /// 具体同事1
        /// </summary>
        public ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }
        /// <summary>
        /// 具体同事2
        /// </summary>
        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.Notify(message);
            }
            else
            {
                colleague1.Notify(message);
            }
        }
    }
}
