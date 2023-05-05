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
            this.view.PrintEvent += AddNewProduct;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SelectCustomerEvent += SelectCustomer;
            this.view.SelectProductEvent += SelectProduct;
         
            //Set pets bindind source
            this.view.SetProductListBindingSource(productBindingSource,pproductBindingSource,cproductBindingSource);

            //Load pet list view
            LoadAllProductList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void SelectCustomer(object sender, EventArgs e)
        {

        }
        private void SelectProduct(object sender, EventArgs e)
        {

        }
        private void LoadAllProductList()
        {
            cproductList = crepository.GetAll();
            cproductBindingSource.DataSource = cproductList;//Set data source.

            pproductList = prepository.GetAll();
            pproductBindingSource.DataSource = pproductList;//Set data source.

            productList = repository.GetAll();
            productBindingSource.DataSource = productList;//Set data source.

        }
            
       
        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
           
        }
       
        private void AddNewProduct(object sender, EventArgs e)
        {
            //view.IsEdit = false;
        }
    }
}
