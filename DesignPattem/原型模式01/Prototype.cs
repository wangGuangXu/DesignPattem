using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式01
{
    /// <summary>
    /// 原型类
    /// </summary>
    public abstract class Prototype
    {
        private string id;
        public Prototype(string id)
        {
            this.id = id;
        }
        public string Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();


    }
}
