using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式03
{
    /// <summary>
    /// 网站工厂
    /// </summary>
    public class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        /// <summary>
        /// 获得网站分类
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key,new ConcreteWebSite(key));
            }

            return ((WebSite)flyweights[key]);
        }

        /// <summary>
        /// 获取网站分类总数
        /// </summary>
        /// <returns></returns>
        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }

    }
}
