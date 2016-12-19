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
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
