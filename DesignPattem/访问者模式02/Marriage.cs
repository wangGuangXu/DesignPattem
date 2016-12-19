using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式02
{
    /// <summary>
    /// 结婚状态类
    /// </summary>
    public class Marriage : Action
    {
        public override void GetManConclussion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时,感慨道：恋爱游戏终结时,'有妻徒刑'遥无期。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时,欣慰曰：爱情长跑路漫漫,婚姻保险保平安。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
