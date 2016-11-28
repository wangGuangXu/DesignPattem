#region 文件注释
/* ===============================================
* 功能描述：GiveGift  
* 创 建 人：王光旭
* 创建日期：2014/11/11 9:35:56
* CLR版本：4.0.30319.18408
* 机器名称：WANGGUANGXU-PC
* 用户所在域：SEINCLUBANK
* 注册组织名：Microsoft
* 命名空间名称：代理模式01
* 当前登录用户名：WangGxu
* ================================================*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式01
{
    /// <summary>
    /// 送礼物接口此处也可以采用抽象类
    /// </summary>
    public interface IGiveGift
    {
        /// <summary>
        /// 送洋娃娃
        /// </summary>
        void GiveDolls();
        /// <summary>
        /// 送鲜花
        /// </summary>
        void GiveFlowers();
        /// <summary>
        /// 送巧克力
        /// </summary>
        void GiveChocolate();
    }
}
