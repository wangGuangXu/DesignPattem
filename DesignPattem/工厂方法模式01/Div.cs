﻿namespace 工厂方法模式01
{
    /// <summary>
    /// 除法-具体产品
    /// </summary>
    public class Div:Operation
    {
        public override double GetResult()
        {
            return NumA / NumB;
        }
    }
}