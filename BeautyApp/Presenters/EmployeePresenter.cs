using BeautyApp.Models;
using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Presenters
{
    class EmployeePresenter
    {

        //Fields
        private IEmployeeView view;
        private IEmployeeRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<EmployeeModel> employeeList;

        //Constructor
        public EmployeePresenter(IEmployeeView view, IEmployeeRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchEmployee;
            this.view.AddNewEvent += AddNewEmployee;
            this.view.EditEvent += LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent += DeleteSelectedEmployee;
            this.view.SaveEvent += SaveEmployee;
            this.view.CancelEvent += CancelAction;
            //Set pets bindind source
            this.view.SetProductListBindingSource(productBindingSource);
            //Load pet list view
            LoadAllEmployeeList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void LoadAllEmployeeList()
        {
            employeeList = repository.GetAll();
            productBindingSource.DataSource = employeeList;//Set data source.
        }
        private void SearchEmployee(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                employeeList = repository.GetByValue(this.view.SearchValue);
            else employeeList = repository.GetAll();
            productBindingSource.DataSource = employeeList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveEmployee(object sender, EventArgs e)
        {
            var model = new EmployeeModel();
            model.Id = Convert.ToInt32(view.Id);
            model.Name = view.EName;
            model.JobName = view.Job_Name;
            model.HireDate = view.Hire_Date;
            model.Salary = view.Salary;
            model.Email = view.Email;
            model.Sex = view.Sex;
            model.Phone = view.Phone;
            model.BirthDate_ = view.Birth_Date;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Employee edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Employee added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllEmployeeList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanviewFields()
        {
            view.Id = "0";
            view.EName = "";
            view.Job_Name = "";
            view.Hire_Date = "";
            view.Salary = "";
            view.Email = "";
            view.Sex = "";
            view.Phone = "";
            view.Birth_Date = "";
        }
        private void DeleteSelectedEmployee(object sender, EventArgs e)
        {
            try
            {
                var employee = (EmployeeModel)productBindingSource.Current;
                repository.Delete(employee.Id);
                view.IsSuccessful = true;
                view.Message = "Employee deleted successfully";
                LoadAllEmployeeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete employee";
            }
        }
        private void LoadSelectedEmployeeToEdit(object sender, EventArgs e)
        {
            var employee = (EmployeeModel)productBindingSource.Current;
            view.Id = employee.Id.ToString();
            view.EName = employee.Name;
            view.Job_Name = employee.JobName;
            view.Hire_Date = employee.HireDate;
            view.Salary = employee.Salary;
            view.Email = employee.Email;
            view.Sex = employee.Sex;
            view.Phone = employee.Phone;         
            view.Birth_Date = employee.BirthDate_;
            view.IsEdit = true;
        }
        private void AddNewEmployee(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}

