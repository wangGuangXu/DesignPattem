using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式02
{
    public class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator)
        {
        }

        /// <summary>
        /// 声明
        /// </summary>
        /// <param name="message"></param>
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        /// <summary>
        /// 获取消息
        /// </summary>
        /// <param name="message"></param>
        public void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方消息:" + message);
        }
    }
}
