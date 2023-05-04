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
    class ProductPresenter
    {
        //Fields
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        //Constructor
        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;
            //Set pets bindind source
            this.view.SetProductListBindingSource(productBindingSource);
            //Load pet list view
            LoadAllProductList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;//Set data source.
        }
        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                productList = repository.GetByValue(this.view.SearchValue);
            else productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveProduct(object sender, EventArgs e)
        {
            var model = new ProductModel();
            model.Id = Convert.ToInt32(view.ProductId);
            model.Name = view.ProductName_;
            model.Description = view.ProductDescription;
            model.Price = view.ProductPrice;
            model.Ammount = view.ProductAmmount;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Product edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Product added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
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
            view.ProductId = "0";
            view.ProductName_ = "";
            view.ProductDescription = "";
            view.ProductPrice = "";
            view.ProductAmmount = "";
        }
        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";
            }
        }
        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;
            view.ProductId = product.Id.ToString();
            view.ProductName_ = product.Name;
            view.ProductDescription = product.Description;
            view.ProductPrice = product.Price;
            view.ProductAmmount = product.Ammount;
            view.IsEdit = true;
        }
        private void AddNewProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
