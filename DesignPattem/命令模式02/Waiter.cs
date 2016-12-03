using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式02
{
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        private Command command;

        /// <summary>
        /// 设置订单
        /// </summary>
        /// <param name="command"></param>
        public void SetOrder(Command command)
        {
            this.command = command;
        }

        /// <summary>
        /// 通知执行
        /// </summary>
        public void Notify()
        {
            command.ExcuteCommand();
        }

    }
}
