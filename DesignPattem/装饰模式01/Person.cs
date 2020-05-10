using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式01
{
    /// <summary>
    /// 对人角色进行抽象
    /// </summary>
    public class Person
    {
        public Person() { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("装饰的{0}",name);
        }
    }
}
