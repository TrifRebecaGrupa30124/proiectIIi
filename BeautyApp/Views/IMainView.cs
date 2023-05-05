using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Views
{
    public interface IMainView
    {
        event EventHandler ShowProductView;
        event EventHandler ShowEmployeeView;
        event EventHandler ShowCustomerView;
        event EventHandler ShowBasketView;
        event EventHandler LogOut;
    }
}
