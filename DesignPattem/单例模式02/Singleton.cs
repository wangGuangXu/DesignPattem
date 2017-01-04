using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式02
{
    /// <summary>
    /// 单例模式 双重锁定机制
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        //程序运行时创建一个静态只读的进程辅助对象
        private static readonly Object obj = new object();

        /// <summary>
        /// 设置私有禁止外部实例话
        /// </summary>
        private Singleton() { }

        #region 自行实例化并返回唯一实例
        /// <summary>
        /// 自行实例化并返回唯一实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            //先判断实例是否存在，不存在再加锁处理
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
