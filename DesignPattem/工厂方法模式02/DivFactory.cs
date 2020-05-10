namespace 工厂方法模式02
{
    /// <summary>
    /// 除法工厂
    /// </summary>
    public class DivFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new Div();
        }
    }
}