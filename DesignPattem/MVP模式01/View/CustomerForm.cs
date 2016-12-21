using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVP模式01.View
{
    /// <summary>
    /// 客户信息窗体
    /// </summary>
    public partial class CustomerForm : Form,ICustomerView
    {
        private bool _isEditMode = false;

        public CustomerForm()
        {
            InitializeComponent();
        }

        #region 窗体属性
        /// <summary>
        /// 
        /// </summary>
        public Presenter.CustomerPresenter Presenter { private get; set; }
        /// <summary>
        /// 客户列表
        /// </summary>
        public IList<string> Customers
        {
            get { return (IList<string>)this.customerListBox.DataSource; }
            set { this.customerListBox.DataSource = value; }
        }
        /// <summary>
        /// 当前选中客户索引项
        /// </summary>
        public int SelectedCustomer
        {
            get { return this.customerListBox.SelectedIndex; }
            set { this.customerListBox.SelectedIndex = value; }
        }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string CustomerName
        {
            get { return this.txtName.Text.Trim(); }
            set { this.txtName.Text = value; }
        }
        /// <summary>
        /// 客户地址
        /// </summary>
        public string Address
        {
            get { return this.txtAddress.Text.Trim(); }
            set { this.txtAddress.Text = value; }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone
        {
            get { return this.txtPhone.Text.Trim(); }
            set { this.txtPhone.Text = value; }
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetControlsStatus(_isEditMode);
            _isEditMode = !_isEditMode;

            this.btnEdit.Text = _isEditMode ? "保存" : "编辑";
            // TODO: add cancel button

            if (!_isEditMode)
            {
                // TODO: validation
                // FIXME: try/catch
                Presenter.SaveCustomer();
            }
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateCustomerView(customerListBox.SelectedIndex);
        }

        private void SetControlsStatus(bool enable)
        {
            this.txtName.Enabled = _isEditMode;
            txtPhone.Enabled = _isEditMode;
            txtAddress.Enabled = _isEditMode;
        }
    }
}
