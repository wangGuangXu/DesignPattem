using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP模式02.Model
{
    public class CustomerModel
    {
        private IList<Customer> _customers = new List<Customer> {
            new Customer { Id="001",FirstName="张",LastName="云逸",Address= "湖北"},
            new Customer { Id="002",FirstName="毛",LastName="泽东",Address= "湖南"}
        };

        public void UpdateCustomer(Customer customer)
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                if (customer.Id == _customers[i].Id)
                {
                    _customers[i] = customer;
                    break;
                }
            }
        }

        public Customer GetCustomerById(string id)
        {
            var customers = from customer in _customers
                           where customer.Id == id
                           select customer.Clone();
            return customers.ToArray<Customer>()[0];
        }

        public Customer[] GetAllCustomers()
        {
            var customers = from customer in _customers
                            select customer.Clone();
            return customers.ToArray<Customer>();
        }

    }
}
