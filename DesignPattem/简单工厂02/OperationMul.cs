﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂02
{
    /// <summary>
    /// 乘法
    /// </summary>
    public class OperationMul:Operation
    {
        /// <summary>
        /// 重写父类的方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumA*NumB;
        }
             
    }
}
