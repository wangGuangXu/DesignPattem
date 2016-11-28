using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂02
{
    /// <summary>
    /// 除法
    /// </summary>
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0d;
            if (NumB==0)
            {
                throw new Exception("除数不能为0");
            }
            result = NumA / NumB;
            return result;
        }
    }
}
