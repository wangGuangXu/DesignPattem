namespace 工厂方法模式02
{
    /// <summary>
    /// 减法工厂
    /// </summary>
    public class SubFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new Sub();
        }
    }
}