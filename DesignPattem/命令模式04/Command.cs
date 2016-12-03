using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式04
{
    /// <summary>
    /// 抽象命令
    /// </summary>
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        abstract public void Execute();
    }
}
