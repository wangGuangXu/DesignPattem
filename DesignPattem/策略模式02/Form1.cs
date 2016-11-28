using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 策略模式02
{
    public partial class Form1 : Form
    {
        private double _totalCount;
        public Form1()
        {
            InitializeComponent();

            cboComputerMethod.Items.AddRange(new Object[] { "正常收费", "打8折", "打7折", "打5折"});
            cboComputerMethod.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double price = double.Parse(txtPrice.Text.Trim());
            double num = double.Parse(txtNum.Text.Trim());
            
            double currentPrice = price * num;

            switch (cboComputerMethod.SelectedIndex)
            {
                case 0:
                    currentPrice = currentPrice * 1;
                    break;
                case 1:
                    currentPrice = currentPrice * 0.8;
                    break;
                case 2:
                    currentPrice = currentPrice * 0.7;
                    break;
                case 3:
                    currentPrice = currentPrice * 0.5;
                    break;
            }

            shopList.Items.Add("商品价格："+price+" 数量："+num+" 计算方式为："+cboComputerMethod.SelectedItem.ToString()+" 合计："+currentPrice);

            _totalCount += currentPrice;
            this.lblTotalCount.Text = _totalCount + "元";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
