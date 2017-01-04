using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式02
{
    /// <summary>
    /// 单例模式 （饿汉方式）
    /// 在类加载时就完成了初始化，所以类加载较慢，但获取对象的速度快
    /// sealed阻止派生，派生类可能会增加实例
    /// </summary>
    public sealed class Singleton2
    {
        /// <summary>
        /// 静态私有成员，已初始化
        /// </summary>
        private static Singleton2 singleton = new Singleton2();

        /// <summary>
        /// 构造函数私有化，放着外部通过new 去实例化
        /// </summary>
        private Singleton2() { }

        /// <summary>
        /// 返回唯一实例
        /// 静态，不用同步（类加载时已初始化，不会有多线程的问题）
        /// </summary>
        /// <returns></returns>
        public static Singleton2 GetInstance()
        {
            return singleton;
        }
    }
}
