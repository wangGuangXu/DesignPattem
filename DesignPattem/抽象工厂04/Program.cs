using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂04
{
    /// <summary>
    /// 用简单工厂改造抽象工厂
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IUser user = DataAccess.CreateUser();   //直接得到数据库实例，不存在任何依赖
            user.GetUser(3);

            IDepartment deparment = DataAccess.CreateDepartment();
            deparment.InsertDepartment(new Department() { Name="研发部" });

        }
    }
}
