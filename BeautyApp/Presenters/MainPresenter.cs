using BeautyApp.Models;
using BeautyApp.Repositories;
using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Presenters
{
    class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
           
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowEmployeeView += ShowEmployeeView;

        }
        private void ShowProductView(object sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
        private void ShowEmployeeView(object sender, EventArgs e)
        {
            IEmployeeView view = EmployeeView.GetInstance((MainView)mainView);
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            new EmployeePresenter(view, repository);

        }
    }
}
