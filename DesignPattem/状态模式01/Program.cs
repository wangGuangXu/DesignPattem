using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式01
{
    class Program
    {
        static int Hour = 0;//小时
        static bool WorkFinished = false;//任务完成标记

        static void Main(string[] args)
        {

        }

        public static void WorkProgram()
        {
            if (Hour > 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", Hour);
            }
            else if (Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", Hour);
            }
            else if (Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", Hour);
            }
            else
            {
                if (WorkFinished)
                {
                    Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", Hour);
                }
                else if (Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班，精神百倍", Hour);
                }
                else
                {
                    Console.WriteLine("当前时间：{0}点 不行了，睡着了", Hour);
                }
            }
        }

    }
}
