using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    /// <summary>
    /// 减法工厂
    /// </summary>
    public class SubFactory:IFactory
    {

        public Operation createOperation()
        {
            return new Sub();
        }
    }
}
