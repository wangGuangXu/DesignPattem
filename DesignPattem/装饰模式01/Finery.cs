using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式01
{
    /// <summary>
    /// 服饰抽象类--抽象产品
    /// </summary>
    public class Finery:Person
    {
        //装饰组件
        protected Person component;

        //装饰
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component!=null)
            {
                component.Show();
            }
        }
    }
}
