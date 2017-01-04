using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式01
{
    /// <summary>
    /// 单例模式 (懒汉单例)
    /// 比较懒，在类加载时，不创建实例，因此类加载速度快，但运行时获取对象的速度慢
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
