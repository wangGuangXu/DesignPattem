using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂01
{
    /// <summary>
    /// 运算类 
    /// </summary>
    public class Operation
    {
        public static double GetResult(double numA, double numB, string operation)
        {
            double result=0d;
            switch (operation)
            {
                case"+":
                    result = numA + numB;
                    break;
                case"-":
                    result = numA - numB;
                    break;
                case"*":
                    result = numA * numB;
                    break;
                case "/":
                    result = numA / numB;
                    break;
            }
            return result;
        }
    }
}