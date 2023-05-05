using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
    interface ICustomerView
    {
        string CustomerId { get; set; }

        string CustomerName_ { get; set; }
        string CustomerEmail { get; set; }
        string CustomerPhone { get; set; }
        string CustomerAddress { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        //Methods
        void SetProductListBindingSource(BindingSource customerList);
        void Show();
    }
}
