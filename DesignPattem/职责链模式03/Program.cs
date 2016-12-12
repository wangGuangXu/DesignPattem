using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式03
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jingli = new CommonManager("经理");
            Majordomo zongjian = new Majordomo("总监");
            GeneralManager zongjingli = new GeneralManager("总经理");

            jingli.SetSuperior(zongjian);
            zongjian.SetSuperior(zongjingli);

            Request request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小菜请假";
            request.Number = 1;
            jingli.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "小菜请假";
            request2.Number = 4;
            jingli.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "小菜请求加薪";
            request3.Number = 500;
            jingli.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "小菜请求加薪";
            request4.Number = 1000;
            jingli.RequestApplications(request4);

            Console.Read();
        }
    }
}
