using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 策略模式04
{
    /// <summary>
    /// 策略模式:定义了算法家族,分别封装起来,分别让他们之间可以相互切换。此模式的算法变化，不会影响到使用算法的客户
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

            //使用策略模式进行现金收费
            CashContext cashSupper = null; 

            switch (cboComputerMethod.SelectedItem.ToString())
            {
                case "正常收费":
                    cashSupper = new CashContext(new CashNomal());
                    break;
                case "打8折":
                    cashSupper = new CashContext(new CashRebat("0.8"));
                    break;
                case "打7折":
                    cashSupper = new CashContext(new CashRebat("0.7"));
                    break;
                case "打5折":
                    cashSupper = new CashContext(new CashRebat("0.5"));
                    break;
                case "满300返100":
                    cashSupper = new CashContext(new CashReturn("300", "100"));
                    break;
                case "满500返200":
                    cashSupper = new CashContext(new CashReturn("500","200"));
                    break;
            }
            //通过算法上下文,调用GetResult()得到计算结果。从而让具体算法与客户端进行了隔离
            currentPrice=cashSupper.GetResult(currentPrice);
            
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
