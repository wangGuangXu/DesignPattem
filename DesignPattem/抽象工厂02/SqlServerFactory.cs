namespace 抽象工厂02
{
    /// <summary>
    /// SqlServer方式具体工厂
    /// </summary>
    public class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}