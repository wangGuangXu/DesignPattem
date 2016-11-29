using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式02
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class Originator
    {
        private string state;
        /// <summary>
        /// 需要保存的属性可能有多个
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// 创建备忘录，将当前需要保存的信息导入并实例化一个备忘录(Memento)对象
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        /// <summary>
        /// 恢复备忘录，将Memento导入并将相关数据恢复
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        public void Show()
        {
            Console.WriteLine("State="+state);
        }

    }
}
