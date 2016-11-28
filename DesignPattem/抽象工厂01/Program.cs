using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂01
{
    /// <summary>
    /// 很初级的方式(不同数据库的快速切换)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerUser sqlUser = new SqlServerUser();

            //插入用户
            sqlUser.InserUser(new User() { Name="张三" });
            
            //得到ID为3的用户
            sqlUser.GetUser(3);

            Console.ReadLine();
        }
    }
}
