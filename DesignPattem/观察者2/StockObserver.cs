using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者2
{
    /// <summary>
    /// 股票观察者
    /// </summary>
    public class StockObserver:Observer
    {
        public StockObserver(string name, Secretary sub):base(name,sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public override void Update()
        {
            Console.WriteLine(string.Format("{0}{1},关闭股票行情，继续工作",sub.SecretaryState, name));
        }

    }
}
