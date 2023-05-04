using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Views
{
    interface ILogInView
    {
        string Admin_Id { get; set; }
        string AdminName { get; set; }
        string AdminPassword { get; set; }

        //Event
        event EventHandler LogInEvent;
    }
}
