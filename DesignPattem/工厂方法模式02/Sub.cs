using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    /// <summary>
    /// 减法-具体产品
    /// </summary>
    public class Sub:Operation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }
}
