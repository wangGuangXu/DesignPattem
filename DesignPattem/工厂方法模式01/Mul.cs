﻿namespace 工厂方法模式01
{
    /// <summary>
    /// 乘法-具体产品
    /// </summary>
    public class Mul:Operation
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }
}