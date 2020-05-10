using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    /// <summary>
    /// 抽象运算类-抽象产品
    /// </summary>
    public abstract class Operation
    {
        public double NumA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double NumB { get; set; }

        /// <summary>
        /// 运算
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();
    }
}