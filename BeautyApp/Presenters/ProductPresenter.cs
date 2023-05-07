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
    class ProductPresenter
    {
        //Fields
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;
        private String fname = "";
        private String path = @"Images\";
        private String beforeEdit;

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
            this.view.CurrentEvent += CurrentProduct;
            this.view.SelectImageEvent += SelectImageProduct;
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
        private void CurrentProduct(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductImage = new Bitmap(path + product.Name + ".png");

        }

        private void SelectImageProduct(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog fd1 = new OpenFileDialog();

                if (fd1.ShowDialog().Equals(DialogResult.OK))
                {
                    fname = fd1.FileName;
                }
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            File.Move(fname, path + view.ProductName_ + ".png");

            /* String dest = "Images/" + view.ProductName_ + "1" + ".jpeg";
             System.IO.File.Copy(fname, dest);
             view.SelectProductImage = new Bitmap(dest);
             if (view.IsSuccessful == true) File.Delete(dest);*/
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
                    if (!beforeEdit.Equals(model.Name))
                    {

                        File.Copy(path + beforeEdit + ".png", path + view.ProductName_ + ".png");

                        //FileInfo file = new FileInfo(path + beforeEdit + ".png");
                        //file.Delete();
                        // File.Move("Images/", "Images/" + view.ProductName_ + ".png");

                        // File.Delete("Images/" + beforeEdit + ".png");

                    }


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
                var nameFile = product.Name;
                // view.ProductImage.Dispose();
                view.ProductImage = null;

                //var l = nameFile.Length;
                //File.Delete(path + nameFile.Substring(0, l-1) + ".png");

                //FileInfo file = new FileInfo(path+nameFile.Substring(0, l - 1) + ".png");
                //file.Delete();
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
            beforeEdit = product.Name;

            view.ProductImageModify = new Bitmap(path + view.ProductName_ + ".png");
            view.IsEdit = true;
        }
        private void AddNewProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}