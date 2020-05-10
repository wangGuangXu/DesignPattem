using System;

namespace 抽象工厂02
{
    /// <summary>
    /// Access方式访问数据--具体产品
    /// </summary>
    public class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据ID得到User表中一条记录");
            return null;
        }

        public void InsertUser(User entity)
        {
            Console.WriteLine("在Access中给User表中增加一条记录");
        }
    }
}