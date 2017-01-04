using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 单例模式03
{
    public partial class Form1 : Form
    {
        //声明一个全局的子窗口变量
        private FormToolCase formToolCase=null;

        public Form1()
        {
            InitializeComponent();
        }

        private void 工具箱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenForm1();

            OpenForm2();

            var form = FormToolCase.GetIntence();
            form.MdiParent = this;
            form.Show();
        }

        #region 1.没运用单例模式之前的打开窗体方式1----会出现子窗口打开多个
        /// <summary>
        /// 1.没运用单例模式之前的打开窗体方式1----会出现子窗口打开多个
        /// </summary>
        private void OpenForm1()
        {
            //var formToolCase = new FormToolCase();

            ////设置本窗体为Mdi容器
            //formToolCase.MdiParent = this;
            //formToolCase.Show();
        }
        #endregion

        #region 2.没运用单例模式之前的打开窗体方式2
        /// <summary>
        /// 2.没运用单例模式之前的打开窗体方式2
        /// </summary>
        private void OpenForm2()
        {
            //这种方式有个弊端就是在子窗口打开后，进行关闭操作后在打开就不会出现。原因是子窗口关闭的时候未销毁全局对象 需要根据子窗口的IsDisposed属性判断
            //if (formToolCase == null || formToolCase.IsDisposed)
            //{
            //    formToolCase = new FormToolCase();
            //    formToolCase.MdiParent = this;
            //    formToolCase.Show();
            //}
        }
        #endregion


    }
}
