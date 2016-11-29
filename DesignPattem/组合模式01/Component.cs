using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式01
{
    /// <summary>
    /// 组件对象
    /// </summary>
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        //通常都用Add和Remove方法来提供增加和移除树叶和树枝的功能
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);

    }
}
