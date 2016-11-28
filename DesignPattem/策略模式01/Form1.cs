using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 策略模式01
{
    public partial class Form1 : Form
    {
        private double _totalCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double price = double.Parse(txtPrice.Text.Trim());
            double num = double.Parse(txtNum.Text.Trim());
            
            double currentPrice = price * num;


            shopList.Items.Add("商品价格："+price+"数量："+num+"合计："+price*num);


            _totalCount += currentPrice;
            this.lblTotalCount.Text = _totalCount + "元";
        }
    }
}
