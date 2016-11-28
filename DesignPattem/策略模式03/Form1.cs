﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 策略模式03
{
    /// <summary>
    /// 简单工厂实现方式
    /// </summary>
    public partial class Form1 : Form
    {
        private double _totalCount;
        public Form1()
        {
            InitializeComponent();

            cboComputerMethod.Items.AddRange(new Object[] { "正常收费", "打8折", "打7折", "打5折", "满300返100", "满500返200" });
            cboComputerMethod.SelectedIndex = 0;
            
            //设置combox只能为只读的不允许输入
            cboComputerMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double price = double.Parse(txtPrice.Text.Trim());
            double num = double.Parse(txtNum.Text.Trim());
            
            double currentPrice = price * num;

            //利用简单工厂模式根据下拉框选择框生成对应的对象
            CashSupper cashSupper = CashFactory.createCashAccept(cboComputerMethod.SelectedItem.ToString());
            currentPrice=cashSupper.acceptCash(currentPrice);
            
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
