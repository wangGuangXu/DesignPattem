using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式03
{
    /// <summary>
    /// 手机品牌
    /// </summary>
    public abstract class HandsetBrand
    {
        protected HandsetSoft soft;

        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        /// <summary>
        /// 运行
        /// </summary>
        public abstract void Run();

    }
}
