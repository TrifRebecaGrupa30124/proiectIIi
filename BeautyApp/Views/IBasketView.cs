using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
     public interface IBasketView
    {
        //string ProductId { get; set; }
      //  string ProductName_ { get; set; }
       // string ProductPrice { get; set; }             
        bool IsSuccessful { get; set; }
        string Message { get; set; }     
        //Events      
        event EventHandler PrintEvent;
        event EventHandler SelectProductEvent;
        event EventHandler SelectCustomerEvent;
        event EventHandler DeleteEvent;
       
        //Methods
        void SetProductListBindingSource(BindingSource productList, BindingSource productList1, BindingSource productList2);
        void Show();
    }
}
