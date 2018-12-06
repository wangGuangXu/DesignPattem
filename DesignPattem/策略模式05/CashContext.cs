using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式05
{
    /// <summary>
    /// 现金算费上下文
    /// </summary>
    public class CashContext
    {
        //声明一个现金算费
        CashSupper cs;
        /// <summary>
        /// 转移客户端的判断,把策略对象创建转移到算法上下文里面
        /// </summary>
        /// <param name="cashSupper"></param>
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNomal();
                    break;
                case "打8折":
                    cs = new CashRebat("0.8");
                    break;
                case "打7折":
                    cs = new CashRebat("0.7");
                    break;
                case "打5折":
                    cs = new CashRebat("0.5");
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "满500返200":
                    cs = new CashReturn("500", "200");
                    break;
            }
        }

        /// <summary>
        /// 根据收费策略的不同，得到相应的结果
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public  double GetResult(double money)
        {
            return cs.acceptCash(money);
        }

    }
}
