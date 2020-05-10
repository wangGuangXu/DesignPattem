using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式02
{
    /// <summary>
    /// 除法工厂
    /// </summary>
    public class DivFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new Div();
        }
    }
}