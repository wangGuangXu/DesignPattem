using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式02
{
    /// <summary>
    /// 人力资源部
    /// </summary>
    public class HRDeparment : Company
    {
        public HRDeparment(string name) : base(name)
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
            Console.WriteLine("{0} 员工招聘培训管理",name);
        }

        public override void Remove(Company c)
        {

        }
    }
}
