using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式04
{
    public class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
