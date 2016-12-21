using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP模式02.Presenter
{
    public class Presenter<IView>
    {
        public IView View { get; private set; }

        public Presenter(IView view)
        {
            this.View = view;
            this.OnViewSet();
        }
        protected virtual void OnViewSet()
        {

        }
    }
}
