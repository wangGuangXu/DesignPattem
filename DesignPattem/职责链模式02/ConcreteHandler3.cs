using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式02
{
    /// <summary>
    /// 职责链模式3
    /// </summary>
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            //20到30,处理此请求
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} 处理请求 {1} ", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                //转移到下一位
                successor.HandleRequest(request);
            }
        }
    }
}
