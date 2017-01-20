using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsApp.Interface;

namespace WinFormsApp.Plugins
{
    /// <summary>
    /// 小写
    /// </summary>
    public class ToLowerCase:IExcutable
    {
        #region IExcutable 成员

        public string Excute(string text)
        {
            return text.ToLower();
        }

        public string GetName()
        {
            return "小写";
        }

        #endregion

    }
}
