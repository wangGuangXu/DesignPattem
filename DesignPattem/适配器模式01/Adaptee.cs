using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式01
{
    /// <summary>
    /// 需要适配的类
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }
}
