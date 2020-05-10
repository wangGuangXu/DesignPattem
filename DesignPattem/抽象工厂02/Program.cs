using System;

namespace 抽象工厂02
{
    /// <summary>
    /// 运用工厂方法模式实现(不同数据库的快速切换)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建具体工厂
            IFactory factory = new SqlServerFactory(); //如果用Access数据库只需要将SqlServerFactory改为AccessFactory就可以了

            //2.根据工厂生产具体
            IUser user= factory.CreateUser();

            user.InsertUser(new User() { Name="成吉思汗" });
            user.GetUser(3);

            Console.ReadKey();
        }
    }
}