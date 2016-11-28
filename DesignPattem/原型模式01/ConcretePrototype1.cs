﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式01
{
    /// <summary>
    /// 具体原型类
    /// </summary>
    public class ConcretePrototype1:Prototype
    {
        public ConcretePrototype1(string id):base(id)
        {
 
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
