using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager jinli = new Manager("经理");
            Manager zongjian = new Manager("总监");
            Manager zongjingli = new Manager("总经理");

            Request request = new Request();
            request.RequestType = "加薪";
            request.RequestContent = "小菜请求加薪";
            request.Number = 1000;

            jinli.GetResult("经理",request);
            zongjian.GetResult("总监", request);
            zongjingli.GetResult("总经理", request);

            Request qingjiaRequest = new Request();
            qingjiaRequest.RequestType = "请假";
            qingjiaRequest.RequestContent = "小菜请假";
            qingjiaRequest.Number = 3;

            jinli.GetResult("经理", qingjiaRequest);
            zongjian.GetResult("总监", qingjiaRequest);
            zongjingli.GetResult("总经理", qingjiaRequest);

            Console.Read();
        }
    }
}
