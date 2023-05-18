using AIMLbot;
using BeautyApp.Models;
using BeautyApp.Repositories;
using BeautyApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Presenters
{
    class MainPresenter
    {
        Thread th;
        private IMainView mainView;
        private readonly string sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {

            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowEmployeeView += ShowEmployeeView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowBasketView += ShowBasketView;
            this.mainView.LogOut += LogOutFunction;
            this.mainView.ShowHomeView += ShowHomeFunction;
            this.mainView.ChatBot += ChatBotFunction;

        }
        private void LogOutFunction(object sender, EventArgs e)
        {

            th = new Thread(tFunction);
            th.Start();


        }
        private void ChatBotFunction(object sender, EventArgs e)
        {

            Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput = false;
            User myuser = new User("User name", AI);
            AI.isAcceptingUserInput = true;
            mainView.QuestionLabel = mainView.Question;
            mainView.Question = "";

            Request r = new Request(mainView.QuestionLabel, myuser, AI);
            Result res = AI.Chat(r);

            mainView.Answer = res.Output;


        }
        private void tFunction(object obj)
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["BeautyApp.Properties.Settings.SqlConnection"].ConnectionString;

            ILogInView view = new LogInView();
            ILogInRepository repository = new LogInRepository(sqlConnectionString);
            new LogInPresenter(view, repository, sqlConnectionString);
            view.AdminName = "";
            view.AdminPassword = "";
            Application.Run((Form)view);
        }
        private void ShowProductView(object sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
        private void ShowHomeFunction(object sender, EventArgs e)
        {
            IHomeView view = HomeView.GetInstance((MainView)mainView);

            new HomePresenter(view);
        }
        private void ShowBasketView(object sender, EventArgs e)
        {
            IBasketView view = BasketView.GetInstance((MainView)mainView);
            IBasketRepository repository = new BasketRepository(sqlConnectionString);
            IProductView pview = ProductView.GetInstance((MainView)mainView);
            IProductRepository prepository = new ProductRepository(sqlConnectionString);
            ICustomerView cview = CustomerView.GetInstance((MainView)mainView);
            ICustomerRepository crepository = new CustomerRepository(sqlConnectionString);
            new BasketPresenter(view, repository, pview, prepository, cview, crepository);
        }
        private void ShowEmployeeView(object sender, EventArgs e)
        {
            IEmployeeView view = EmployeeView.GetInstance((MainView)mainView);
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            new EmployeePresenter(view, repository);

        }
        private void ShowCustomerView(object sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstance((MainView)mainView);
            ICustomerRepository repository = new CustomerRepository(sqlConnectionString);
            new CustomerPresenter(view, repository);
        }
    }
}