using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace 抽象工厂05
{
    /// <summary>
    /// 通过反射创建对象
    /// </summary>
    public class DataAccess
    {
        private static readonly string AssemblyName = "抽象工厂05";
        private static readonly string db = "SqlServer";

        /// <summary>
        /// 创建用户抽象产品的工厂方法
        /// </summary>
        /// <returns></returns>
        public static IUser CreateUser()
        {
            string className= AssemblyName + "." + db + "User";
            
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        /// <summary>
        /// 创建部门抽象产品的工厂方法
        /// </summary>
        /// <returns></returns>
        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";

            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
