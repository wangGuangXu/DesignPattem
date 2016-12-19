using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式03
{
    /// <summary>
    /// 
    /// </summary>
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcreteElementB(this);
        }

        /// <summary>
        /// 其他相关方法
        /// </summary>
        public void OperationB()
        {

        }
    }
}
