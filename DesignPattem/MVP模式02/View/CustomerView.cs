using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVP模式02.Model;
using MVP模式02.Presenter;

namespace MVP模式02.View
{
    public partial class CustomerView : ViewBase, ICustomerView
    {
        public CustomerView()
        {
            InitializeComponent();
        }
        protected override object CreatePresenter()
        {
            return new CustomerPresenter(this);
        }

        public event EventHandler<CustomerEventArgs> CustomerSaving;
        public event EventHandler<CustomerEventArgs> CustomerSelected;

        public void Clear()
        {
            this.btnOK.Enabled = false;
            this.txtId.Text = string.Empty;
            this.txtFirstName.Text = string.Empty;
            this.txtLastName.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
        }

        public void DisplayCustomerInfo(Customer customer)
        {
            this.txtId.Text = customer.Id;
            this.txtFirstName.Text = customer.FirstName;
            this.txtLastName.Text = customer.LastName;
            this.txtAddress.Text = customer.Address;
        }

        public void ListAllCustomers(Customer[] customers)
        {
            this.dataGridViewCustomers.DataSource = customers;
        }

        protected virtual void OnCustomerSelected(string customerId)
        {
            var previousId = this.txtId.Text.Trim();
            if (customerId == previousId)
            {
                return;
            }
            if (null != this.CustomerSelected)
            {
                this.CustomerSelected(this, new CustomerEventArgs { CustomerId = customerId });
            }
        }
        protected virtual void OnCustomerSaving(Customer customer)
        {
            if (null != this.CustomerSaving)
            {
                this.CustomerSaving(this, new CustomerEventArgs { Customer=customer});
            }
        }

        private void dataGridViewCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRow = this.dataGridViewCustomers.Rows[e.RowIndex];
            var customerId = currentRow.Cells[0].Value.ToString();
            //this.OnCustomerSelected(customerId);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.Id = this.txtId.Text.Trim();
            customer.FirstName = this.txtFirstName.Text.Trim();
            customer.LastName = this.txtLastName.Text.Trim();
            customer.Address = this.txtAddress.Text.Trim();

            this.OnCustomerSaving(customer);
        }
    }
}
