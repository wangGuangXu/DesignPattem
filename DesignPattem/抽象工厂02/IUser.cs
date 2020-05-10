namespace 抽象工厂02
{
    /// <summary>
    /// 抽象产品
    /// </summary>
    public interface IUser
    {
        User GetUser(int id);
        void InsertUser(User entity);
    }
}