using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂04
{
    //增加工厂类改造抽象工厂
    public class DataAccess
    {
        private static readonly string db = "SqlServer";
        //private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            IUser result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlServerUser();
                    break;
                case "Access":
                    result = new AccessUser();
                    break;
                default:
                    break;
            }
            return result;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlServerDepartment();
                    break;
                case "Access":
                    result = new AccessDepartment();
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
