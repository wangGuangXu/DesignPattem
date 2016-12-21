using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP模式01.View
{
    /// <summary>
    /// 客户视图接口
    /// </summary>
    public interface ICustomerView
    {
        IList<string> Customers { get; set; }

        int SelectedCustomer { get; set; }

        string CustomerName { get; set; }
        string Address { get; set; }
        string Phone { get; set; }

        Presenter.CustomerPresenter Presenter { set; }
    }
}
