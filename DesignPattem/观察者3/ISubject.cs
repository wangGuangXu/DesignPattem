using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者3
{
    /// <summary>
    /// 抽象通知者接口
    /// </summary>
    public interface ISubject
    {
        void Attach(Observer observer);

        void Detach(Observer observer);

        void Notify();

        string SubjectState { get; set; }

    }
}
