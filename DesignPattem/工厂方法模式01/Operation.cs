using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式01
{
    /// <summary>
    /// 运算抽象类-抽象产品
    /// </summary>
    public abstract class Operation
    {
        /// <summary>
        /// 数字A
        /// </summary>
        public double NumA { get; set; }
        /// <summary>
        /// 数字B
        /// </summary>
        public double NumB { get; set; }

        /// <summary>
        /// 抽象运算方法
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();
    }
}
