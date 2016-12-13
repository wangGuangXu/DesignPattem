using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式04
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public User(string name)
        {
            this.name = name;
        }
    }
}
