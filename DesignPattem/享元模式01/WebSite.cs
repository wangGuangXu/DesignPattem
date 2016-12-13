using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式01
{
    /// <summary>
    /// 网站
    /// </summary>
    public class WebSite
    {
        private string name = "";

        public WebSite(string name)
        {
            this.name = name;
        }

        public void Use()
        {
            Console.WriteLine("网站分类："+name);
        }

    }
}
