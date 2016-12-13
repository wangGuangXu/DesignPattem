using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式01
{
    /// <summary>
    /// 具体同事1
    /// </summary>
    public class ConcreteColleague1:Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// 发送消息是由中介者发送出去的
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            mediator.Send(message,this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事 1 得到消息 :"+message);
        }
    }
}
