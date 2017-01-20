using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Interface;

namespace WinFormsApp
{
    /// <summary>
    /// 使用说明：
    /// 在程序跟目录下创建Plugins文件夹，然后将插件项目中所生成的dll放到主程序bin目录下的插件目录下
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadPlugins();
        }

        /// <summary>
        /// 主程序加载插件
        /// </summary>
        private void LoadPlugins()
        {
            List<IExcutable> list = Common.Common.GetPlugins();
            foreach (var plugin in list)
            {
                var item = new ToolStripMenuItem(plugin.GetName());
                item.Name = plugin.GetName();
                item.Click += new EventHandler(Plugin_Click);
                item.Tag = plugin;
                this.Plugins.DropDownItems.Add(item);
            }
        }

        /// <summary>
        /// 创建插件公共事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plugin_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (null == item) return;

            if (null == item.Tag) return;

            IExcutable plugin = item.Tag as IExcutable;
            if (null == plugin) return;

            textBox1.Text = plugin.Excute(textBox1.Text);
        }

    }
}
