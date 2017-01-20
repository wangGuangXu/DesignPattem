using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsApp.Interface;

namespace WinFormsApp.Plugins
{
    /// <summary>
    /// 十六进制插件
    /// </summary>
    public class Hex:IExcutable
    {
        #region IExcutable 成员

        public string Excute(string text)
        {
            return text.ToUpper();
        }

        public string GetName()
        {
            return "十六进制";
        }
        #endregion
    }
}
