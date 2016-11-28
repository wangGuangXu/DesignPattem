#region 文件注释
/* ===============================================
* 功能描述：CashContext  
* 创 建 人：王光旭
* 创建日期：2014/11/8 9:25:28
* CLR版本：4.0.30319.18408
* 机器名称：WANGGUANGXU-PC
* 用户所在域：SEINCLUBANK
* 注册组织名：Microsoft
* 命名空间名称：策略模式04
* 当前登录用户名：WangGxu
* ================================================*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式04
{
    /// <summary>
    /// 现金算费上下文
    /// </summary>
    public class CashContext
    {
        //声明一个现金算费
        CashSupper cs;
        /// <summary>
        /// 通过构造方法,传入具体的收费策略
        /// </summary>
        /// <param name="cashSupper"></param>
        public CashContext(CashSupper cashSupper)
        {
            this.cs = cashSupper;
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
