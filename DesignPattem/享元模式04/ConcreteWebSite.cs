using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式04
{
    public class ConcreteWebSite:WebSite
    {
        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类："+ name+ " 用户：" + user.Name);
        }
    }
}
