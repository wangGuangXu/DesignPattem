using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式01
{
    /// <summary>
    /// 女人
    /// </summary>
    public class Woman : Person
    {
        public override void GetConclusion()
        {
            if (action == "成功")
            {
                Console.WriteLine("{0}{1}时,背后大多有一个不成功的男人。", this.GetType().Name, action);
            }
            else if (action == "失败")
            {
                Console.WriteLine("{0}{1}时,眼泪汪汪,谁也劝不了。", this.GetType().Name, action);
            }
            else if (action == "恋爱")
            {
                Console.WriteLine("{0}{1}时,遇事懂也装作不懂。", this.GetType().Name, action);
            }
        }
    }
}
