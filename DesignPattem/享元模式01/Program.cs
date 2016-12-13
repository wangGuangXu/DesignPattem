using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSite fx = new WebSite("产品展示");
            fx.Use();

            WebSite fy = new WebSite("产品展示");
            fy.Use();

            WebSite fz = new WebSite("产品展示");
            fz.Use();

            WebSite fl = new WebSite("博客");
            fl.Use();

            WebSite fm = new WebSite("博客");
            fm.Use();

            WebSite fn = new WebSite("博客");
            fn.Use();

            Console.Read();
        }
    }
}
