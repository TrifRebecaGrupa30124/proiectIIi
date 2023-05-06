using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Presenters
{
    class HomePresenter
    {
        private IHomeView view;

        public HomePresenter(IHomeView view)
        {
            this.view = view;
            this.view.Show();
        }
    }
}
