namespace 抽象工厂02
{
    /// <summary>
    /// Access方式的工厂
    /// </summary>
    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}