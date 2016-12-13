using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式02
{
    public class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }

        /// <summary>
        /// 声明
        /// </summary>
        /// <param name="message"></param>
        public void Declare(string message)
        {
            mediator.Declare(message,this);
        }

        /// <summary>
        /// 获得消息
        /// </summary>
        /// <param name="message"></param>
        public void GetMessage(string message)
        {
            Console.WriteLine("伊拉克获得对方信息："+message);
        }

    }
}
