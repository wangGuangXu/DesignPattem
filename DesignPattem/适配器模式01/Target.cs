using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式01
{
    /// <summary>
    /// 客户所期待的接口
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.Write("普通请求");
        }
    }
}
