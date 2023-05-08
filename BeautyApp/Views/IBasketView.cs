using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
    public interface IBasketView
    {
        string Total { get; set; }
        string CustomerName { get; set; }
        string stringForPrint { get; set; }
        string CustomerPhone { get; set; }
        string CustomerAddress { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        event EventHandler PrintEvent;
        event EventHandler SelectProductEvent;
        event EventHandler SelectCustomerEvent;
        event EventHandler CurrentEvent;

        event EventHandler DeleteEvent;
        void SetProductListBindingSource(BindingSource productList, BindingSource productList1, BindingSource productList2);
        void Show();
    }
}