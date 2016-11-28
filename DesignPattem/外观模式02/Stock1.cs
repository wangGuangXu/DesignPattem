using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式02
{
    #region 股票1
    /// <summary>
    /// 股票1
    /// </summary>
    public class Stock1
    {
        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票1买入");
        }

        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票1卖出");
        }
    }
    #endregion

    #region 股票2
    /// <summary>
    /// 股票2
    /// </summary>
    public class Stock2
    {
        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票2买入");
        }

        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票2卖出");
        }
    }
    #endregion

    #region 股票3
    /// <summary>
    /// 股票3
    /// </summary>
    public class Stock3
    {
        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票3买入");
        }

        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票3卖出");
        }
    }
    #endregion

    #region 国债1
    /// <summary>
    /// 国债1
    /// </summary>
    public class NationalDebt1
    {
        /// <summary>
        /// 买国债
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("国债3买入");
        }

        /// <summary>
        /// 卖国债
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("国债3卖出");
        }
    }
    #endregion

    #region 房地产
    /// <summary>
    /// 房地产
    /// </summary>
    public class Retalty1
    {
        /// <summary>
        /// 买房地产
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("房地产1买入");
        }
        /// <summary>
        /// 卖房地产
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("房地产1卖出");
        }
    }
    #endregion

}
