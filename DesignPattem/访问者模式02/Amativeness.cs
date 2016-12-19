using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式02
{
    /// <summary>
    /// 恋爱状态
    /// </summary>
    public class Amativeness : Action
    {
        public override void GetManConclussion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时,凡事不懂也要装懂。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时,遇事懂也装作不懂。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
