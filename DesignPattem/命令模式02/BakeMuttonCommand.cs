using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式02
{
    /// <summary>
    /// 拷羊肉串命令
    /// </summary>
    public class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {

        }
        /// <summary>
        /// 执行拷羊肉串命令
        /// </summary>
        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
