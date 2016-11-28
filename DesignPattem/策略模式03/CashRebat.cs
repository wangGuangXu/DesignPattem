#region 文件注释
/* ===============================================
* 功能描述：CashRebat  
* 创 建 人：王光旭
* 创建日期：2014/11/7 17:14:31
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

namespace 策略模式03
{
    /// <summary>
    /// 打折收费
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
