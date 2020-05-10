namespace 工厂方法模式01
{
    /// <summary>
    /// 运算工厂
    /// </summary>
    public class OperationFactory
    {
        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <param name="operate">运算符</param>
        /// <returns></returns>
        public static Operation CreateOperate(string operate)
        {
            Operation oper;
            switch (operate)
            {
                case "+":
                    oper = new Add();
                    break;
                case"-":
                    oper = new Sub();
                    break;
                case "*":
                    oper = new Mul();
                    break;
                case "/":
                    oper = new Div();
                    break;
            }
            return null;
        }
    }
}