using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式02
{
    /// <summary>
    /// 抽象处理者
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// 抽象继承者
        /// </summary>
        protected Handler successor;
        /// <summary>
        /// 设置继承者
        /// </summary>
        /// <param name="successor"></param>
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// 处理请求的抽象方法
        /// </summary>
        /// <param name="request"></param>
        public abstract void HandleRequest(int request);

    }
}
