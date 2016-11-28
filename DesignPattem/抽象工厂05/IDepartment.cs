using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂05
{
    /// <summary>
    /// 部门抽象接口
    /// </summary>
    public interface IDepartment
    {
        Department GetDepartment(int id);

        void InsertDepartment(Department entity);
    }
}
