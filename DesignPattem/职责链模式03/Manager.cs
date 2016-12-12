using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式03
{
    /// <summary>
    /// 管理者
    /// </summary>
    public abstract class Manager
    {
        protected string name;
        /// <summary>
        /// 管理者的上级
        /// </summary>
        protected Manager superior;
        public Manager(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 设置管理者的上级
        /// </summary>
        /// <param name="superior"></param>
        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        abstract public void RequestApplications(Request request);

    }
}
