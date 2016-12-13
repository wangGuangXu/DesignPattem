using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式02
{
    /// <summary>
    /// 国家
    /// </summary>
    public abstract class Country
    {
        protected UnitedNations mediator;
        public Country(UnitedNations mediator)
        {
            this.mediator = mediator; 
        }
    }
}
