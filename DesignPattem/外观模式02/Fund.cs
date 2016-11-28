using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式02
{
    /// <summary>
    /// 基金
    /// </summary>
    public class Fund
    {
        Stock1 gu1;
        Stock1 gu2;
        Stock1 gu3;

        NationalDebt1 nd1;
        Retalty1 rt1;

        /// <summary>
        /// 需要了解所有的股票(相关类型)进行组合，以备外界调用
        /// </summary>
        public Fund()
        {
            gu1 = new Stock1();
            gu2 = new Stock1();
            gu3 = new Stock1();

            nd1 = new NationalDebt1();
            rt1 = new Retalty1();
        }

        /// <summary>
        /// 买基金
        /// </summary>
        public void BuyFund()
        {
            gu1.Buy();
            gu2.Buy();
            gu3.Buy();

            nd1.Buy();
            rt1.Buy();
        }

        /// <summary>
        /// 卖基金
        /// </summary>
        public void SellFund()
        {
            gu1.Sell();
            gu2.Sell();
            gu3.Sell();

            nd1.Sell();
            rt1.Sell();
        }
    }
}
