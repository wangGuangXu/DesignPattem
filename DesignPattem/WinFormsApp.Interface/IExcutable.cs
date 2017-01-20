using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp.Interface
{
    /// <summary>
    /// 可执行接口
    /// </summary>
    public interface IExcutable
    {
        /// <summary>
        /// 获取名称
        /// </summary>
        /// <returns></returns>
        string GetName();
        /// <summary>
        /// 执行具体的文本操作
        /// </summary>
        /// <returns></returns>
        string Excute(string text);

    }
}
