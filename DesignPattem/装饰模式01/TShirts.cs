#region 文件注释
/* ===============================================
* 功能描述：TShirts  
* 创 建 人：王光旭
* 创建日期：2014/11/8 13:26:31
* CLR版本：4.0.30319.18408
* 机器名称：WANGGUANGXU-PC
* 用户所在域：SEINCLUBANK
* 注册组织名：Microsoft
* 命名空间名称：装饰模式01
* 当前登录用户名：WangGxu
* ================================================*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式01
{
    /// <summary>
    /// T恤--具体产品
    /// </summary>
    public class TShirts:Finery
    {

        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
}
