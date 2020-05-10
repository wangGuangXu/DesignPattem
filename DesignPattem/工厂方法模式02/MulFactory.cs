using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    /// <summary>
    /// 乘法工厂
    /// </summary>
    public class MulFactory:IFactory
    {

        public Operation CreateOperation()
        {
            return new Mul();
        }
    }
}