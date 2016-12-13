using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式03
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory factory = new WebSiteFactory();

            WebSite fx =factory.GetWebSiteCategory("产品展示");
            fx.Use();

            WebSite fy = factory.GetWebSiteCategory("产品展示");
            fy.Use();

            WebSite fz = factory.GetWebSiteCategory("产品展示");
            fz.Use();

            WebSite fl = factory.GetWebSiteCategory("博客");
            fl.Use();

            WebSite fm = factory.GetWebSiteCategory("博客");
            fm.Use();

            WebSite fn = factory.GetWebSiteCategory("博客");
            fn.Use();

            Console.WriteLine("网站分类总数为："+factory.GetWebSiteCount());

            Console.Read();
        }
    }
}
