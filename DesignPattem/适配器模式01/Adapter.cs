using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式01
{
    /// <summary>
    /// 
    /// </summary>
    public class Adapter:Target
    {
        //建立一个私有的Adptee对象
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            //这样就可以把表面上调用Request()方法变成实际调用SpecificRequest()
            adaptee.SpecificRequest();
        }
    }
}
