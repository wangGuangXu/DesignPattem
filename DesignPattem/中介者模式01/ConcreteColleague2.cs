using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式01
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// 发送消息是由中介者发送出去的
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事 2 得到消息 :" + message);
        }
    }
}
