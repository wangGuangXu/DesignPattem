using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式01
{
    /// <summary>
    /// 包含解释器之外的一些全局信息
    /// </summary>
    public class Context
    {
        private string input;
        private string output;

        /// <summary>
        /// 输入
        /// </summary>
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        /// <summary>
        /// 输出
        /// </summary>
        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
