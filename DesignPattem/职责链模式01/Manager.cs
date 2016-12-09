using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式01
{
    /// <summary>
    /// 管理者
    /// </summary>
    public class Manager
    {
        protected string name;
        public Manager(string name)
        {
            this.name = name;
        }

        public void GetResult(string managerLevel, Request request)
        {
            if (managerLevel=="经理")
            {
                if (request.RequestType == "请假" && request.Number <= 2)
                {
                    Console.WriteLine("{0}:{1} {2}天 被批准", name, request.RequestContent, request.Number);
                }
                else
                {
                    Console.WriteLine("{0}:{1} {2}天 我无权处理", name, request.RequestContent, request.Number);
                }
            }
            else if (managerLevel=="总监")
            {
                if (request.RequestType == "请假" && request.Number <= 5)
                {
                    Console.WriteLine("{0}:{1} {2}天 被批准", name, request.RequestContent, request.Number);
                }
                else {
                    Console.WriteLine("{0}:{1} {2}天 我无权处理", name, request.RequestContent, request.Number);
                }
            }
            else if (managerLevel == "总经理")
            {
                if (request.RequestType == "请假")
                {
                    Console.WriteLine("{0}:{1} {2}天 被批准", name, request.RequestContent, request.Number);
                }
                else if (request.RequestType == "加薪" && request.Number <= 500)
                {
                    Console.WriteLine("{0}:{1} 数量{2} 再说吧", name, request.RequestContent, request.Number);
                }
                else
                {
                    Console.WriteLine("{0}:{1} 数量{2} 我无权处理", name, request.RequestContent, request.Number);
                }
            }
        }

    }
}
