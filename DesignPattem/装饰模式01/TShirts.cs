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
