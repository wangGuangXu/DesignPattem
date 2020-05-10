namespace 抽象工厂03
{
    /// <summary>
    /// SqlServer方式具体工厂
    /// </summary>
    public class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}