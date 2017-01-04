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
    public partial class FormToolCase : Form
    {
        private static FormToolCase formToolCase=null;

        //public FormToolCase()
        //{
        //    InitializeComponent();
        //}

        /// <summary>
        /// 将构造函数私有化不允许从外部实例化，从而控制窗口打开的个数
        /// </summary>
        private FormToolCase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体内部去创建自身
        /// </summary>
        /// <returns></returns>
        public static FormToolCase GetIntence()
        {
            if (formToolCase == null || formToolCase.IsDisposed)
            {
                formToolCase = new FormToolCase();
            }
            return formToolCase;
        }

    }
}
