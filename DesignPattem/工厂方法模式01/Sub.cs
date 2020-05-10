﻿namespace 工厂方法模式01
{
    /// <summary>
    /// 减法-具体产品
    /// </summary>
    public class Sub:Operation
    {
        /// <summary>
        /// 重写抽象方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }
}