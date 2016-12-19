using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式02
{
    /// <summary>
    /// 男人
    /// </summary>
    public class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclussion(this);
        }
    }
}
