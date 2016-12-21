using MVP模式02.Model;
using MVP模式02.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVP模式02.Presenter
{
    public class CustomerPresenter : Presenter<ICustomerView>
    {
        public CustomerModel Model { get; set; }

        public CustomerPresenter(ICustomerView view):base(view)
        {
            this.Model = new CustomerModel();
        }

        protected override void OnViewSet()
        {
            this.View.Load += (sender, args) =>
              {
                  Customer[] customers = this.Model.GetAllCustomers();
                  this.View.ListAllCustomers(customers);
                  this.View.Clear();
              };
            this.View.CustomerSelected += (sender, args) =>
              {
                  Customer customer = this.Model.GetCustomerById(args.CustomerId);
                  this.View.DisplayCustomerInfo(customer);
              };
            this.View.CustomerSaving += (sender, args) =>
              {
                  this.Model.UpdateCustomer(args.Customer);
                  Customer[] customers = this.Model.GetAllCustomers();
                  this.View.ListAllCustomers(customers);
                  this.View.Clear();
                  MessageBox.Show("The customer has been successfully updated!", "Successfully Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
              };
        }
        
    }
}
