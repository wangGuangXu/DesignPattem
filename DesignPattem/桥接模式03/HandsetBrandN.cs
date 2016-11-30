using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式03
{
    /// <summary>
    /// 手机品牌诺基亚
    /// </summary>
    public class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
