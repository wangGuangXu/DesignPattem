using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp.Interface
{
    /// <summary>
    /// 扩展可执行接口
    /// </summary>
    public interface IExcutableExtension:IExcutable
    {
        void Excute(Control control);

    }
}
