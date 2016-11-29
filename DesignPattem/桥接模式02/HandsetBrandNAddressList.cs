using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式02
{
    public class HandsetBrandNAddressList : HandsetBrand
    {
        public override void Run()
        {
            Console.WriteLine("运行N品牌手机通讯录");
        }
    }
}
