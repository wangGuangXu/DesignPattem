using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式02
{
    /// <summary>
    /// 失败状态
    /// </summary>
    public class Failing : Action
    {
        public override void GetManConclussion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时,闷头喝酒,谁也不用劝。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时,眼泪汪汪,谁也劝不了。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
