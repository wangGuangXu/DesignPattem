﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂04
{
    /// <summary>
    /// SqlServer部门产品
    /// </summary>
    public class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SqlServer中根据ID得到Department表中一条记录");
            return null;
        }

        public void InsertDepartment(Department entity)
        {
            Console.WriteLine("在SqlServer中给Department表中增加一条记录");
        }
    }
}
