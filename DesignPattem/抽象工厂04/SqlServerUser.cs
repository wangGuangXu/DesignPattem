﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂04
{
    /// <summary>
    /// 具体产品
    /// </summary>
    public class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中根据ID得到User表中一条记录");
            return null;
        }

        public void InsertUser(User entity)
        {
            Console.WriteLine("在SQL Server中给User表中增加一条记录");
        }
    }
}
