using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());

            //成功时的反应
            Success v1 = new Success();
            o.Display(v1);

            //失败时的反应
            Failing v2 = new Failing();
            o.Display(v2);

            //恋爱时的反应
            Amativeness v3 = new Amativeness();
            o.Display(v3);

            //结婚时的反应
            Marriage v4 = new Marriage();
            o.Display(v4);


            Console.Read();
        }
    }
}
