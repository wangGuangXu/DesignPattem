using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式03
{
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        private IList<Command> orders=new List<Command>();

        /// <summary>
        /// 设置订单
        /// </summary>
        /// <param name="command"></param>
        public void SetOrder(Command command)
        {
            if (command.ToString() == "命令模式03.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员: 鸡腿没有了,请点别的烧烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单: " + command.ToString() + " 时间: " + DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="command"></param>
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单: " + command.ToString() + " 时间: " + DateTime.Now.ToString());
        }

        /// <summary>
        /// 通知全部执行
        /// </summary>
        public void Notify()
        {
            foreach (Command cmd in orders)
            {
                cmd.ExcuteCommand();
            }
        }

    }
}
