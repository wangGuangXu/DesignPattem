using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式03
{
    class Program
    {
        static void Main(string[] args)
        {
            //大战Boss前
            GameRole xiaoyao = new GameRole();
            //游戏角色初始状态，
            xiaoyao.GetInitState();
            xiaoyao.StateDisplay();

            //保存进度
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            //保存进度时，由于封装在备忘录中，因此并不知道保存了哪些具体的角色数据
            stateAdmin.Memento = xiaoyao.SaveState();

            //开打
            xiaoyao.Fight();
            xiaoyao.StateDisplay();

            //恢复之前状态
            xiaoyao.RecoveryState(stateAdmin.Memento);
            xiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
