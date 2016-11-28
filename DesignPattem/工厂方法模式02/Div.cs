using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    /// <summary>
    /// 除法-具体产品
    /// </summary>
    public class Div:Operation
    {
        public override double GetResult()
        {
            return NumA / NumB;
        }
    }
}
