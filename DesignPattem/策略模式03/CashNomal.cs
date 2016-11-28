using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式03
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CashNomal:CashSupper
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
