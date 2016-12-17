using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式01
{
    /// <summary>
    /// 非终结符表达式
    /// </summary>
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
