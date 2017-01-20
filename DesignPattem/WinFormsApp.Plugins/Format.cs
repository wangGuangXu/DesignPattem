using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Interface;

namespace WinFormsApp.Plugins
{
    /// <summary>
    /// 格式化插件
    /// </summary>
    public class Format:IExcutableExtension
    {
        #region IExcutableExtension 成员

        public void Excute(System.Windows.Forms.Control ctrl)
        {
            TextBox txtBox = ctrl as TextBox;
            txtBox.Text = "IExcutableExtension";
        }

        #endregion

        #region IExcutable 成员

        public string Excute(string text)
        {
            return text.ToUpper();
        }

        public string GetName()
        {
            return "格式化";
        }

        #endregion
    }
}
