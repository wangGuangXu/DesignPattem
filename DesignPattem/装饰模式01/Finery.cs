#region 文件注释
/* ===============================================
* 功能描述：Finery  
* 创 建 人：王光旭
* 创建日期：2014/11/8 13:25:16
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
    /// 服饰抽象类--抽象产品
    /// </summary>
    public class Finery:Person
    {
        //装饰组件
        protected Person component;

        //装饰
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component!=null)
            {
                component.Show();
            }
        }
    }
}
