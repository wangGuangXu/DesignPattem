using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式01
{
    /// <summary>
    /// 男人
    /// </summary>
    public class Man : Person
    {
        public override void GetConclusion()
        {
            if (action=="成功")
            {
                Console.WriteLine("{0}{1}时,背后多半有一个伟大的女人。",this.GetType().Name,action);
            }
            else if (action=="失败")
            {
                Console.WriteLine("{0}{1}时,闷头喝酒,谁也不用劝。", this.GetType().Name, action);
            }
            else if (action == "恋爱")
            {
                Console.WriteLine("{0}{1}时,凡事不懂也要装懂。", this.GetType().Name, action);
            }
        }
    }
}
