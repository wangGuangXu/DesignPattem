using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式02
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume wgx = new Resume("wgx");
            wgx.SetPersonInfo("男", "24");
            wgx.SetWorkExperience("五年", "架构师");
            wgx.Display();


            Resume zsf = (Resume)wgx.Clone();
            zsf.SetWorkExperience("80年","武当山武术架构师");
            zsf.Display();

            Console.ReadKey();

        }
    }
}
