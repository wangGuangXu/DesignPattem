using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式02
{
    /// <summary>
    /// 学生甲的试卷
    /// </summary>
    public class TestPageA: TestPager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Answer1()
        {
            return "b";
        }

        public override string Answer2()
        {
            return "c";
        }

        public override string Answer3()
        {
            return "a";
        }

    }
}
