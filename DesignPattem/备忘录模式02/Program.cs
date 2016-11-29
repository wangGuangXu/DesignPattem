using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            //初始状态为On
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            //保存状态时，由于有了很好的封装，可以隐藏Orginator的实现细节
            c.Memento = o.CreateMemento();

            //更改状态属性为Off
            o.State = "Off";
            o.Show();

            //恢复原初始状态
            o.SetMemento(c.Memento);
            o.Show();

            Console.Read();
        }
    }
}
