using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式03
{
    /// <summary>
    /// 手机品牌摩托罗拉
    /// </summary>
    public class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
