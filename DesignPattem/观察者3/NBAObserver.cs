﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者3
{
    /// <summary>
    /// NBA观察者
    /// </summary>
    public class NBAObserver:Observer
    {
        public NBAObserver(string name,ISubject sub):base(name,sub)
        {

        }

        public override void Update()
        {
            Console.WriteLine(string.Format("{0}{1},关闭NBA直播，继续工作", sub.SubjectState, name));
        }

    }
}
