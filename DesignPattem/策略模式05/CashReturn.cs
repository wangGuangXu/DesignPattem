using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式05
{
    /// <summary>
    /// 返现--具体算费策略
    /// </summary>
    public class CashReturn:CashSupper
    {
        private double moneyCondition = 0d; //满足返现的条件
        private double moneyReturn = 0d;    //返现金额

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        /// <summary>
        /// 重写父类结算现金的方法
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            double result = 0d;
            if (money>moneyCondition)
            {
                result = money-Math.Floor((money /moneyCondition))*moneyReturn ;
            }
            return result;
        }

    }
}
