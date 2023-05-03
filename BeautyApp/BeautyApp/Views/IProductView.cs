﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
    public interface IProductView
    {
        string ProductId { get; set; }
        string ProductName_ { get; set; }
        string ProductDescription { get; set; }
        string ProductPrice { get; set; }
        string ProductAmmount { get; set; }
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
        void SetProductListBindingSource(BindingSource petList);
        void Show();
    }
}
