using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学生甲的试卷答案：");
            TestPageA studentA = new TestPageA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();
            studentA.TestQuestion3();

            Console.WriteLine("学生乙的试卷答案：");

            TestPageB studentB = new TestPageB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();
            studentB.TestQuestion3();

            Console.Read();
        }
    }
}
