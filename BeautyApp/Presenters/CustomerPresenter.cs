using BeautyApp.Models;
using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Presenters
{
    class CustomerPresenter
    {
        //Fields
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        //Constructor
        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;
        
            //Set pets bindind source
            this.view.SetProductListBindingSource(customerBindingSource);

            //Load pet list view
            LoadAllCustomerList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void LoadAllCustomerList()
        {

            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;//Set data source.

        }
        private void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                customerList = repository.GetByValue(this.view.SearchValue);
            else customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
     
        private void SaveCustomer(object sender, EventArgs e)
        {
            var model = new CustomerModel();
            model.Id = Convert.ToInt32(view.CustomerId);
            model.Name = view.CustomerName_;
            model.Email = view.CustomerEmail;
            model.Phone = view.CustomerPhone;
            model.Address = view.CustomerAddress;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Customer edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Customer added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
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
            view.CustomerId = "0";
            view.CustomerName_ = "";
            view.CustomerEmail = "";
            view.CustomerPhone = "";
            view.CustomerAddress = "";
        }
        private void DeleteSelectedCustomer(object sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customerBindingSource.Current;
                repository.Delete(customer.Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete customer";
            }
        }
        private void LoadSelectedCustomerToEdit(object sender, EventArgs e)
        {
            var customer = (CustomerModel)customerBindingSource.Current;
            view.CustomerId = customer.Id.ToString();
            view.CustomerName_ = customer.Name;
            view.CustomerEmail = customer.Email;
            view.CustomerPhone = customer.Phone;
            view.CustomerAddress = customer.Address;

            view.IsEdit = true;
        }
        private void AddNewCustomer(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
