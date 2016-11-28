using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者04
{
    /// <summary>
    /// 具体建造者2
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();
        public override void BuilderA()
        {
            product.Add("部件x");
        }

        public override void BuilderB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
