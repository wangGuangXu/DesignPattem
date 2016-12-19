using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式03
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    public abstract class Visitor
    {
        public abstract void VisitorConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitorConcreteElementB(ConcreteElementB concreteElementB);
    }
}
