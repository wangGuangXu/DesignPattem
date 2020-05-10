namespace 工厂方法模式02
{
    /// <summary>
    /// 加法工厂
    /// </summary>
    public class AddFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new Add();
        }
    }
}