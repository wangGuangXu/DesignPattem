using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式03
{
    /// <summary>
    /// 具体
    /// </summary>
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcreteElementA(this);
        }

        /// <summary>
        /// 其他相关方法
        /// </summary>
        public void OperationA()
        {

        }
    }
}
