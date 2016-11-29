using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式02
{
    /// <summary>
    /// 财务部
    /// </summary>
    public class FinanceDeparment : Company
    {
        public FinanceDeparment(string name) : base(name)
        {

        }
        public override void Add(Company c)
        {
            
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="depth"></param>
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        /// <summary>
        /// 职责
        /// </summary>
        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理",name);
        }

        public override void Remove(Company c)
        {
            
        }
    }
}
