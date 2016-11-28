using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式05
{
    /// <summary>
    /// 现金收费--抽象策略类
    /// </summary>
    public  abstract class CashSupper
    {
        /// <summary>
        /// 现金收费抽象方法
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public abstract double acceptCash(double money);
    }
}
