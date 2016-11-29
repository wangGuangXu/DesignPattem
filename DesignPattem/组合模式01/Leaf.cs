using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式01
{
    /// <summary>
    /// 叶节点对象
    /// </summary>
    public class Leaf:Component
    {
        public Leaf(string name)
            : base(name)
        {

        }

        /// <summary>
        /// 由于叶子节点对象没有在增加分枝和树叶所以Add和Remove方法实现它没有意义
        /// 但这样做可以消除叶节点和枝节点在抽象层次的区别，它们具备完全一致的接口
        /// </summary>
        /// <param name="c"></param>
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot Remove to a leaf");
        }

        /// <summary>
        /// 叶节点的具体方法
        /// </summary>
        /// <param name="depth"></param>
        public override void Display(int depth)
        {
            //此处是显示起名称和级别
            Console.WriteLine(new String('-', depth)+name);
        }


    }
}
