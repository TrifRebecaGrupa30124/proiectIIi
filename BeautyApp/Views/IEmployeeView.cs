using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
    public interface IEmployeeView
    {
        string Id { get; set; }
        string EName { get; set; }
        string Job_Name { get; set; }
        string Hire_Date { get; set; }
        string Salary { get; set; }
        string Email { get; set; }
        string Sex { get; set; }
        string Phone { get; set; }
        string Birth_Date { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        //Methods
        void SetProductListBindingSource(BindingSource employeeList);
        void Show();



    }
}
