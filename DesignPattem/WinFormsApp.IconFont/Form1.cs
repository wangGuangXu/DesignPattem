using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp.IconFont
{
    //注意事项： 需要把字体文件安装到本机才可以起作用，尤其是从一台机子切换到另外一台机子的时候
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "\ue603";
            label1.Font = new Font("iconfont", 32);
            label1.ForeColor = Color.Red;

            label2.Text = "\ue625";
            label2.Font = new Font("iconfont", 34);
            label3.ForeColor = Color.Green;

            label3.Text = "\ue61a";
            label3.Font = new Font("iconfont", 32);
            label3.ForeColor = Color.Firebrick;

            label4.Text = "\ue6bd";
            label4.Font = new Font("iconfont", 32);
            label4.ForeColor = Color.Blue;

            label5.Text = "\ue998";
            label5.Font = new Font("iconfont", 28);
            label5.ForeColor = Color.DarkBlue;

            label6.Text = "\ue6f0";
            label6.Font = new Font("iconfont", 32);
            label6.ForeColor = Color.DarkOrange;
        }
    }
}
