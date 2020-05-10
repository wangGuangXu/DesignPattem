using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂02
{
    /// <summary>
    /// 简单工厂类
    /// </summary>
    public class OperationFactory
    {
        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <param name="operation">运算符</param>
        /// <returns></returns>
        public static Operation createOperation(string operation)
        {
            Operation oper;
            switch (operation)
            {
                case"+":
                    oper=new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return null;
        }
    }
}