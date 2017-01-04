using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 单例模式03
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //单例模式工作场景下运用
            Application.Run(new Form1());
        }
    }
}
