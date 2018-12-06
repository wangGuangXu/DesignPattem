using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式05
{
    /// <summary>
    /// 打折收费--具体算费策略
    /// </summary>
    public class CashRebat:CashSupper
    {
        private double moneyRebate = 1d;
        public CashRebat(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * this.moneyRebate;
        }
    }
}
