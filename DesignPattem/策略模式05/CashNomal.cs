using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式05
{
    /// <summary>
    /// 正常收费子类--具体算费策略
    /// </summary>
    public class CashNomal:CashSupper   //继承有助于析取出这种算法的公共功能
    {
        /// <summary>
        /// 原价
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
