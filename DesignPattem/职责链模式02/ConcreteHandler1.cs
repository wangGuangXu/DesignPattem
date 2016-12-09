using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式02
{
    /// <summary>
    /// 具体处理者1
    /// </summary>
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            //0到10,处理此请求
            if (request >= 0 && request < 10)
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
