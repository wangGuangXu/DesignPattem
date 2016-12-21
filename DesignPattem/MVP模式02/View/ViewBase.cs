using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVP模式02.View
{
    public partial class ViewBase : Form
    {
        private object _presenter;
        public ViewBase()
        {
            _presenter = this.CreatePresenter();
        }

        protected virtual object CreatePresenter()
        {
            if (LicenseManager.CurrentContext.UsageMode == LicenseUsageMode.Designtime)
            {
                return null;
            }
            else
            {
                throw new NotImplementedException(string.Format("{0} must override the CreatePresenter method.", this.GetType().FullName));
            }
        }
    }
}
