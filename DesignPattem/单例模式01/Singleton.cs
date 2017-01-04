using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式01
{
    /// <summary>
    /// 单例模式 (懒汉单例)
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        
        //私有构造函数禁止外部访问
        private Singleton() { }

        /// <summary>
        /// 自行实例化并返回唯一实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (instance==null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
