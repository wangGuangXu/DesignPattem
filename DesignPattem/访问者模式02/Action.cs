using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式02
{
    /// <summary>
    /// 状态抽象类
    /// </summary>
    public abstract class Action
    {
        /// <summary>
        /// 得到男人结论或反应
        /// </summary>
        /// <param name="concreteElementA"></param>
        public abstract void GetManConclussion(Man concreteElementA);

        /// <summary>
        /// 得到女人结论或反应
        /// </summary>
        /// <param name="concreteElementB"></param>
        public abstract void GetWomanConclusion(Woman concreteElementB);
    }
}
