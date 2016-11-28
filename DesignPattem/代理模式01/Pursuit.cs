#region 文件注释
/* ===============================================
* 功能描述：Pursuit  
* 创 建 人：王光旭
* 创建日期：2014/11/11 9:35:32
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
    /// 追求者
    /// </summary>
    public class Pursuit:IGiveGift
    {

        SchoolGirl sg;

        public Pursuit(SchoolGirl sg)
        {
            this.sg = sg;
        }
        /// <summary>
        /// 送洋娃娃
        /// </summary>
        public void GiveDolls()
        {
            Console.WriteLine(sg.Name + "送洋娃娃");
        }
        /// <summary>
        /// 送鲜花
        /// </summary>
        public void GiveFlowers()
        {
            Console.WriteLine(sg.Name + "送鲜花");
        }
        /// <summary>
        /// 送巧克力
        /// </summary>
        public void GiveChocolate()
        {
            Console.WriteLine(sg.Name + "送巧克力");
        }
    }
}
