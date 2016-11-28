using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者04
{
    /// <summary>
    /// 抽象建造者类
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuilderA();

        public abstract void BuilderB();

        public abstract Product GetResult();

    }
}
