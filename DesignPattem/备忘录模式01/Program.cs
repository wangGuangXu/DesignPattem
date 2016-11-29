using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式01
{
    /// <summary>
    /// 采用第一种方式保存进度
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //大战 Boss 前
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保存进度
            GameRole backup = new GameRole();
            backup.Vitality = lixiaoyao.Vitality;
            backup.Attack = lixiaoyao.Attack;
            backup.Defense = lixiaoyao.Defense;

            //大战 Boss时，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前状态
            lixiaoyao.Vitality = backup.Vitality;
            lixiaoyao.Attack = backup.Attack;
            lixiaoyao.Defense = backup.Defense;

            lixiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
