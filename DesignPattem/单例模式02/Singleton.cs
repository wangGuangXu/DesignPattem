using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式02
{
    /// <summary>
    /// 单例模式 双重锁机制
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        private static readonly Object obj = new object();

        /// <summary>
        /// 设置私有禁止外部实例话
        /// </summary>
        private Singleton() { }

        #region 返回唯一的实例
        /// <summary>
        /// 返回唯一的实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        } 
        #endregion


    }
}
