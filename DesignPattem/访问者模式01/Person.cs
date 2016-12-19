using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式01
{
    /// <summary>
    /// 人类
    /// </summary>
    public abstract class Person
    {
        protected string action;
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        /// <summary>
        /// 得到结论或者反应
        /// </summary>
        public abstract void GetConclusion();
    }
}
