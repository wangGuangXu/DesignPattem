using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式02
{
    /// <summary>
    /// 公司类
    /// </summary>
    public abstract class Company
    {
        protected string name;
        public Company(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="c"></param>
        public abstract void Add(Company c);

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="c"></param>
        public abstract void Remove(Company c);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="depth"></param>
        public abstract void Display(int depth);

        /// <summary>
        /// 履行职责
        /// 不同的部门履行不同的职责
        /// </summary>
        public abstract void LineOfDuty();

    }
}
