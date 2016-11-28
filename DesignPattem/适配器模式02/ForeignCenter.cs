using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式02
{
    /// <summary>
    /// 外籍翻译
    /// </summary>
    public class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 表示外籍中锋只懂得中文进攻
        /// </summary>
        public void 进攻()
        {
            Console.WriteLine("外籍中锋 {0} 进攻",name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋 {0} 防守",name);
        }

    }
}
