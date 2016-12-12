using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式03
{
    /// <summary>
    /// 经理
    /// </summary>
    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else
            {
                if (superior!=null)
                {
                    //其余的申请都需要转到上级
                    superior.RequestApplications(request);
                }
            }
        }
    }
}
