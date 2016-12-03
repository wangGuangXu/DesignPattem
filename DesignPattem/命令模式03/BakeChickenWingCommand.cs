using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式03
{
    /// <summary>
    /// 烤鸡腿
    /// </summary>
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        /// <summary>
        /// 执行烤鸡腿命令
        /// </summary>
        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
