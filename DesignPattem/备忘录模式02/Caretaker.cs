using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式02
{
    /// <summary>
    /// 管理者
    /// </summary>
    public class Caretaker
    {
        private Memento memento;
        /// <summary>
        /// 得到或设置备忘录
        /// </summary>
        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }


    }
}
