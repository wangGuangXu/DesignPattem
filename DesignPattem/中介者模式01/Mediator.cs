using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式01
{
    /// <summary>
    /// 中介者
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// 定义 一个抽象的发送消息方法，得到同事对象和发送信息
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        abstract public void Send(string message, Colleague colleague);
    }
}
