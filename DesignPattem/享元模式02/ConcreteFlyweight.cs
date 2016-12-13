using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式02
{
    /// <summary>
    /// 
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体Flyweight:"+extrinsicstate);
        }
    }
}
