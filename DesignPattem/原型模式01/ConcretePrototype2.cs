using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式01
{
    /// <summary>
    /// 具体原型2
    /// </summary>
    public class ConcretePrototype2:Prototype
    {
        public ConcretePrototype2(string id) : base(id) 
        {
            
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
