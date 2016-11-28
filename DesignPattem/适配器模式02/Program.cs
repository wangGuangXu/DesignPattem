using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 不带翻译的时候代码写法
            //Player forwards = new Forwards("巴蒂尔");
            //forwards.Attack();

            //Player guards = new Guards("麦克格雷迪");
            //guards.Attack();

            //Player center = new Center("姚明");
            ////由于姚明刚到NBA不动英语，所以说进攻和防守姚明是听不懂，这种写法是有问题的，需要进行翻译，也就是去适配
            //center.Attack();
            //center.Defense();
            #endregion

            #region 带翻译的时候代码写法(采用适配器)
            Player forwards = new Forwards("巴蒂尔");
            forwards.Attack();

            Player guards = new Guards("麦克格雷迪");
            guards.Attack();

            Player center = new Translator("姚明");
            center.Attack();
            center.Defense();

            #endregion


            Console.Read();
        }
    }
}
