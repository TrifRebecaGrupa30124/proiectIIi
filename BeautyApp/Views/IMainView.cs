using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Views
{
    public interface IMainView
    {

        string Answer { get; set; }
        string Question { get; set; }
        string QuestionLabel { get; set; }

        event EventHandler ShowProductView;
        event EventHandler ShowEmployeeView;
        event EventHandler ShowCustomerView;
        event EventHandler LogOut;
        event EventHandler ShowBasketView;
        event EventHandler ShowHomeView;
        event EventHandler ChatBot;
    }
}