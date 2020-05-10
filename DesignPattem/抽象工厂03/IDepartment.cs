namespace 抽象工厂03
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