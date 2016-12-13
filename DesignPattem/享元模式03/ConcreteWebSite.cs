using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式03
{
    public class ConcreteWebSite:WebSite
    {
        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use()
        {
            Console.WriteLine("网站分类："+name);
        }
    }
}
