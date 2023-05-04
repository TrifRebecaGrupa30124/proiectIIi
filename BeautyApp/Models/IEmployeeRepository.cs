using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    interface IEmployeeRepository
    {
        void Add(EmployeeModel employeeModel);
        void Edit(EmployeeModel employeeModel);
        void Delete(int id);
        IEnumerable<EmployeeModel> GetAll();
        IEnumerable<EmployeeModel> GetByValue(string value);//Searchs
    }
}
