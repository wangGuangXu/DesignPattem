using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂02
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface IFactory
    {
        IUser CreateUser();
    }
}
