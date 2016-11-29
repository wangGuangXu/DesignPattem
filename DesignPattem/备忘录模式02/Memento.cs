using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式02
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class Memento
    {
        private string state;
        /// <summary>
        /// 需要保存的属性可以是多个
        /// </summary>
        public string State
        {
            get { return state; }
        }
        /// <summary>
        /// 将相关数据从构造方法导入
        /// </summary>
        /// <param name="state"></param>
        public Memento(string state)
        {
            this.state = state;
        }

    }
}
