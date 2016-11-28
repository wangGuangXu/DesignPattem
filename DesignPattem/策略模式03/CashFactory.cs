#region 文件注释
/* ===============================================
* 功能描述：CashFactory  
* 创 建 人：王光旭
* 创建日期：2014/11/7 17:24:48
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
    /// 现金算费工厂
    /// </summary>
    public class CashFactory
    {
        /// <summary>
        /// 现金工厂
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static CashSupper createCashAccept(string type)
        {
            CashSupper cashSupper = null;
            switch (type)
            {
                case"正常收费":
                    cashSupper = new CashNomal();
                    break;
                case "打8折":
                    cashSupper = new CashRebat("0.8");
                    break;
                case "打7折":
                    cashSupper = new CashRebat("0.7");
                    break;
                case "打5折":
                    cashSupper = new CashRebat("0.5");
                    break;
                case "满300返100":
                    cashSupper = new CashReturn("300","100");
                    break;
                case "满500返200":
                    cashSupper = new CashReturn("500", "200");
                    break;
            }
            return cashSupper;
        }
        
    }
}
