using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式01
{
    /// <summary>
    /// 透明方式 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //生成树根
            Composite root = new Composite("root");

            //根上长出两个叶节点
            root.Add(new Leaf("叶节点 A"));
            root.Add(new Leaf("叶节点 B"));

            //根上长出分枝节点Composite X
            Composite comp = new Composite("Composite X");
            //分枝上长出两片叶子
            comp.Add(new Leaf("叶节点 A"));
            comp.Add(new Leaf("叶节点 B"));

            root.Add(comp);

            //在分枝Composite X节点上产生一个新的分枝 Composite XY
            Composite comp2 = new Composite("Composite XY");
            //分枝Composite XY上也长出两片叶子
            comp2.Add(new Leaf("叶节点 XYA"));
            comp2.Add(new Leaf("叶节点 XYB"));

            comp.Add(comp2);

            //根部又长出两个叶节点C和D
            root.Add(new Leaf("叶节点 C"));

            Leaf leaf = new Leaf("叶节点 D");
            root.Add(leaf);

            //根部长出的叶节点D由于没长牢，被风吹走了
            root.Remove(leaf);

            //显示大树的叶子
            root.Display(1);

            Console.Read();
        }
    }
}
