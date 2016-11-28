using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者03
{
    /// <summary>
    /// 建造指挥者
    /// </summary>
    public class PersonDirector
    {
        private PersonBuilder personBuilder;
        public PersonDirector(PersonBuilder personBuilder)
        {
            this.personBuilder = personBuilder;
        }

        public void CreatePerson()
        {
            personBuilder.BuilderHead();

            personBuilder.BuilderBody();

            personBuilder.BuilderArmLeft();
            personBuilder.BuilderArmRight();

            personBuilder.BuilderLegLeft();
            personBuilder.BuilderLegRight();
        }
    }
}
