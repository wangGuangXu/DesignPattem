using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式01
{
    /// <summary>
    /// 定义枝节点行为，用于存储子部件
    /// </summary>
    public class Composite : Component
    {
        private List<Component> cheildren = new List<Component>();
        public Composite(string name)
            : base(name)
        {

        }

        public override void Add(Component c)
        {
            cheildren.Add(c);
        }

        public override void Remove(Component c)
        {
            cheildren.Remove(c);
        }

        public override void Display(int depth)
        {
            //显示其枝节点名称并对其下级进行遍历
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in cheildren)
            {
                component.Display(depth+2);
            }
        }
        
    }
}
