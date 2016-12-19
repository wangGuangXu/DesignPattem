using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式02
{
    /// <summary>
    /// 对象结构
    /// </summary>
    public class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="element"></param>
        public void Attach(Person element)
        {
            elements.Add(element);
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="element"></param>
        public void Detach(Person element)
        {
            elements.Remove(element);
        }

        /// <summary>
        /// 查看显示
        /// </summary>
        /// <param name="visitor"></param>
        public void Display(Action visitor)
        {
            foreach (Person item in elements)
            {
                item.Accept(visitor);
            }
        }


    }
}
