using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式02
{
    /// <summary>
    /// 享元工厂
    /// </summary>
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            //初始化工厂时，生成3个实例
            flyweights.Add("X",new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        /// <summary>
        /// 根据客户端请求获取已生成的实例
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight) flyweights[key]);
        }

    }
}
