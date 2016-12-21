using MVP模式01.Model;
using MVP模式01.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP模式01.Presenter
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerPresenter
    {
        private readonly ICustomerView _view;
        private readonly ICustomerRepository _repository;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;

            UpdateCustomerListView();
        }

        private void UpdateCustomerListView()
        {
            var customerNames = from customer in _repository.GetAllCustomers() select customer.Name;
            int selectedCustomer = _view.SelectedCustomer >= 0 ? _view.SelectedCustomer : 0;
            _view.Customers = customerNames.ToList();
            _view.SelectedCustomer = selectedCustomer;
        }

        public void UpdateCustomerView(int p)
        {
            // customer list can be cached instead of re-fetching the customer each time
            // this may be infeasible if the list is large
            Customer customer = _repository.GetCustomer(p);
            _view.CustomerName = customer.Name;
            _view.Address = customer.Address;
            _view.Phone = customer.Phone;
        }

        public void SaveCustomer()
        {
            Customer customer = new Customer { Name = _view.CustomerName, Address = _view.Address, Phone = _view.Phone };
            _repository.SaveCustomer(_view.SelectedCustomer, customer);
            UpdateCustomerListView();
        }

    }
}
