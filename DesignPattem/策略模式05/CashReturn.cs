#region 文件注释
/* ===============================================
* 功能描述：CashReturn  
* 创 建 人：王光旭
* 创建日期：2014/11/7 17:17:30
* CLR版本：4.0.30319.18408
* 机器名称：WANGGUANGXU-PC
* 用户所在域：SEINCLUBANK
* 注册组织名：Microsoft
* 命名空间名称：策略模式03
* 当前登录用户名：WangGxu
* ================================================*/
#endregion
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
