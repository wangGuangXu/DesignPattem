using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式01
{
    /// <summary>
    /// 垮裤-具体产品
    /// </summary>
    public class BigTrouser:Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
}
