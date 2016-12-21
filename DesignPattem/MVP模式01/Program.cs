using MVP模式01.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP模式01
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

            var repository = new Model.CustomerXmlRepository(Application.StartupPath);
            var view = new View.CustomerForm();

            // 待办事项 (TODO): 依赖注入(IOC)
            var presenter = new Presenter.CustomerPresenter(view, repository);

            Application.Run(view);
        }
    }
}
