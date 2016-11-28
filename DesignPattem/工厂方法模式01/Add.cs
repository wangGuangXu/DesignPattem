using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式01
{
    /// <summary>
    /// 加法运算-具体产品
    /// </summary>
    public class Add:Operation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }
}
