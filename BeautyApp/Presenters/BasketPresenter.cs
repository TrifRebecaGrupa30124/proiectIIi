using BeautyApp.Models;
using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Presenters
{
    class BasketPresenter
    {
        //Fields
        private IBasketView view;
        private IBasketRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<BasketModel> productList;
        private IProductView pview;
        private IProductRepository prepository;
        private BindingSource pproductBindingSource;
        private IEnumerable<ProductModel> pproductList;
        private ICustomerView cview;
        private ICustomerRepository crepository;
        private BindingSource cproductBindingSource;
        private IEnumerable<CustomerModel> cproductList;


        //Constructor
        public BasketPresenter(IBasketView view, IBasketRepository repository, IProductView pview, IProductRepository prepository, ICustomerView cview, ICustomerRepository crepository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.pproductBindingSource = new BindingSource();
            this.pview = pview;
            this.prepository = prepository;
            this.cproductBindingSource = new BindingSource();
            this.cview = cview;
            this.crepository = crepository;
            //Subscribe event handler methods to view events
            this.view.CurrentEvent += SelectProduct;
            this.view.PrintEvent += AddNewProduct;
            this.view.DeleteEvent += DeleteSelectedProduct;

            this.view.SelectCustomerEvent += SelectCustomer;

            //Set pets bindind source
            this.view.SetProductListBindingSource(productBindingSource, pproductBindingSource, cproductBindingSource);

            //Load pet list view
            LoadAllProductList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void LoadAllProductList()
        {


            pproductList = prepository.GetAll();
            pproductBindingSource.DataSource = pproductList;
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;//Set data source.
            cproductList = crepository.GetAll();
            cproductBindingSource.DataSource = cproductList;//Set data source.

        }

        private void SelectCustomer(object sender, EventArgs e)
        {
            var customer = (CustomerModel)cproductBindingSource.Current;
            view.CustomerAddress = customer.Address;
            view.CustomerName = customer.Name;
            view.CustomerPhone = customer.Phone;

        }

        private void SelectProduct(object sender, EventArgs e)
        {
            var product = (ProductModel)pproductBindingSource.Current;
            var model = new BasketModel();
            model.Id = product.Id;

            model.Name = product.Name.ToString();

            model.Price = product.Price.ToString();
            repository.Add(model);
            LoadAllProductList();
        }



        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {

                var basket = (BasketModel)productBindingSource.Current;

                repository.Delete(basket.Id);
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

        private void AddNewProduct(object sender, EventArgs e)
        {
            //view.IsEdit = false;
        }
    }
}