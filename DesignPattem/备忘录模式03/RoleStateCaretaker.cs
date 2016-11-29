using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式03
{
    /// <summary>
    /// 角色状态管理者
    /// </summary>
    public class RoleStateCaretaker
    {
        private RoleStateMemento memento;
        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }

    }
}
