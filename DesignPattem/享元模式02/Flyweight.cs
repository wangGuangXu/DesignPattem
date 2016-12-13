using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式02
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Flyweight
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extrinsicstate"></param>
        public abstract void Operation(int extrinsicstate);
    }
}
