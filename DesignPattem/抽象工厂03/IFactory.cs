namespace 抽象工厂03
{
    /// <summary>
    /// 抽象工厂 (应该包含所有产品创建的抽象方法)
    /// </summary>
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
        
    }
}