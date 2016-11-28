using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂03
{
    /// <summary>
    /// 运用抽象工厂模式实现(不同数据库的快速切换)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建具体工厂
            IFactory factory = new AccessFactory();

            //2.通过工厂生成具体产品
            IDepartment department = factory.CreateDepartment();

            //3.根据id获取部门
            department.GetDepartment(3);

            Console.ReadKey();
        }
    }
}
