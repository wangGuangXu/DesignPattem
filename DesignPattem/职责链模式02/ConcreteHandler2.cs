using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式02
{
    /// <summary>
    /// 具体处理者2
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        public override void HandleRequest(int request)
        {
            //10到20,处理此请求
            if (request>=10 && request<20)
            {
                Console.WriteLine("{0} 处理请求 {1} ",this.GetType().Name,request);
            }
            else if (successor!=null)
            {
                //转移到下一位
                successor.HandleRequest(request);
            }
        }
    }
}
