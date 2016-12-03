using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式04
{
    /// <summary>
    /// 具体命令
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
