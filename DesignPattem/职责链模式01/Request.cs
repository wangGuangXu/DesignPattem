using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式01
{
    /// <summary>
    /// 申请
    /// </summary>
    public class Request
    {
        private string requestType;
        /// <summary>
        /// 申请类别
        /// </summary>
        public string RequestType {
            get { return requestType; }
            set { requestType = value; }
        }
        private string requestContent;
        /// <summary>
        /// 申请内容
        /// </summary>
        public string RequestContent
        {
            get { return requestContent; }
            set { requestContent = value; }
        }
        private int number;
        /// <summary>
        /// 申请数量
        /// </summary>
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
