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
        /// <summary>
        /// 客户列表
        /// </summary>
        IList<string> Customers { get; set; }
        /// <summary>
        /// 当前选中客户
        /// </summary>
        int SelectedCustomer { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        string CustomerName { get; set; }
        /// <summary>
        /// 客户手机号
        /// </summary>
        string Phone { get; set; }
        /// <summary>
        /// 客户地址
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// MVP模式中控制的核心
        /// </summary>
        Presenter.CustomerPresenter Presenter { set; }
    }
}
