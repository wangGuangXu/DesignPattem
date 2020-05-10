using System;

namespace 抽象工厂05
{
    /// <summary>
    /// 反射+抽象工厂方式实现数据访问
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IUser iUser = DataAccess.CreateUser();
            iUser.InsertUser(new User() { Name="赵一曼" });

            IDepartment iDepartment = DataAccess.CreateDepartment();
            iDepartment.GetDepartment(3);

            Console.ReadKey();
        }
    }
}