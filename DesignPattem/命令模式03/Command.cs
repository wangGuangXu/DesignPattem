using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式03
{
    /// <summary>
    /// 抽象命令
    /// </summary>
    public abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        abstract public void ExcuteCommand();
    }
}
