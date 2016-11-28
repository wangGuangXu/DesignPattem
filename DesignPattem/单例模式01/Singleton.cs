using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式01
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        
        //私有构造函数禁止外部访问
        private Singleton() { }

        //返回唯一实例
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
