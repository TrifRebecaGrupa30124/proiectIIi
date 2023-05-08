using BeautyApp.Models;
using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            this.view.PrintEvent += PrintPageFunction;
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
            int totalAdd = 0;
            IEnumerable<BasketModel> c = repository.GetAll();
            foreach (var cust in c)
            {
                int petId = int.TryParse(cust.Price, out _) ? Convert.ToInt32(cust.Price) : 0;
                totalAdd = totalAdd + petId;
            }
            view.Total = "" + totalAdd.ToString();
        }

        private void SelectCustomer(object sender, EventArgs e)
        {
            var customer = (CustomerModel)cproductBindingSource.Current;
            view.CustomerAddress = customer.Address;
            view.CustomerName = customer.Name;
            view.CustomerPhone = customer.Phone;

        }
        void PrintPageFunction(object sender, EventArgs e)
        {
            /* PrintPageEventArgs ke = e as PrintPageEventArgs;
             String factura = "Factura emisa \n Date client:\n Nume: "+view.CustomerName+"\n Telefon: "+view.CustomerPhone+"\n Adresa: "+view.CustomerAddress+
                 "\n";
             e.Graphics.DrawString("ttt", new Font("Centuey Gothic", 12, FontStyle.Regular), Brushes.Black, new PointF(130, 130));
            */
            int total = 0;
            view.stringForPrint = "\n \t \t \t Factura emisa \n \n \t Date client \n Nume: " + view.CustomerName + "\n Telefon: " + view.CustomerPhone + "\n Adresa: " + view.CustomerAddress +
              "\n \n \t Date Produse  \n";

            // Print the value one column of each DataRow.\

            IEnumerable<BasketModel> c = repository.GetAll();
            foreach (var cust in c)
            {
                view.stringForPrint = view.stringForPrint + cust.Name + " " + cust.Price + "\n";
                total = total + int.Parse(cust.Price);
            }
            view.stringForPrint = view.stringForPrint + "\n Total: " + total.ToString() + "\n \n Data emiterii facturii: " + DateTime.Now.ToString(" MM dd yyyy");
            view.Total = "Total:" + total.ToString();
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
            int totalAdd = 0;
            IEnumerable<BasketModel> c = repository.GetAll();
            foreach (var cust in c)
            {
                int petId = int.TryParse(cust.Price, out _) ? Convert.ToInt32(cust.Price) : 0;
                totalAdd = totalAdd + petId;
            }
            view.Total = "Total:" + totalAdd.ToString();
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
                int totalAdd = 0;
                IEnumerable<BasketModel> c = repository.GetAll();
                foreach (var cust in c)
                {
                    int petId = int.TryParse(cust.Price, out _) ? Convert.ToInt32(cust.Price) : 0;
                    totalAdd = totalAdd + petId;
                }
                view.Total = "Total:" + totalAdd.ToString();


            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";
            }
        }

        private void AddNewProduct(object sender, EventArgs e)
        {


        }
    }
}