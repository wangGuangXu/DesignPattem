namespace 抽象工厂03
{
    /// <summary>
    /// Access方式的工厂(具体工厂创建具有特定实现的产品对象)
    /// </summary>
    public class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}