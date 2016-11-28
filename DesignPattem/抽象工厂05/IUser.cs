using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂05
{
    /// <summary>
    /// 抽象产品
    /// </summary>
    public interface IUser
    {
        User GetUser(int id);
        void InsertUser(User entity);
    }
}
