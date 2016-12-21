using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MVP模式02.View
{
    public interface IViewBase
    {
        event EventHandler Load;
        event EventHandler Closed;
        event CancelEventHandler Closing;
    }
}
