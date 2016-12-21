using MVP模式02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP模式02.View
{
    public class CustomerEventArgs : EventArgs
    {
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
