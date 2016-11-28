using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者04
{
    /// <summary>
    /// 指挥者
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 用来指挥具体建造过程
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuilderA();
            builder.BuilderB();
        }
    }
}
