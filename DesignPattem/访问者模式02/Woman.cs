using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式02
{
    /// <summary>
    /// 女人
    /// </summary>
    public class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}
