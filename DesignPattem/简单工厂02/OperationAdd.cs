using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂02
{
    /// <summary>
    /// 加法---具体运算类
    /// </summary>
    public class OperationAdd:Operation
    {
        /// <summary>
        /// 重写父类的得到结果的虚方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumA + NumB;
        }

    }
}
