using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂02
{
    /// <summary>
    /// 运算类--运算基类
    /// </summary>
    public  class Operation
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
        /// 定义一个计算结果的虚方法让子类去重写
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            return 0;
        }
    }
}
