using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式02
{
    /// <summary>
    /// 单例
    /// </summary>
    public class Singleton1
    {
        private static Singleton1 singleton1;
        /// <summary>
        /// 创建一个静态只读的进程辅助对象
        /// </summary>
        private static readonly Object syncRoot = new object();

        /// <summary>
        /// 构造函数私有化，放着外部通过new 去实例化
        /// </summary>
        private Singleton1() { }

        /// <summary>
        /// 自行实例化并返回唯一实例
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstance()
        {
            /*
             * 在同一个时刻加了锁，的那部分程序只有一个线程可进入
             * 为什么不直接对 singleton1加锁，原因是加锁的时候 singleton1加锁有没有被创建不得而知，所以不能对它加锁
             * 此方式会影响性能 改善条件(可采用双重锁定机制)
             */
            lock (syncRoot)
            {
                if (singleton1==null)
                {
                    singleton1 = new Singleton1();
                }
            }
            return singleton1;
        }
    }
}
