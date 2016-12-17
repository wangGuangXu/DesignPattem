using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式01
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
