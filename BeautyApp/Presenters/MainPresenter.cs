﻿using BeautyApp.Models;
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
            this.mainView.LogOut += LogOutFunction;

        }
        private void LogOutFunction(object sender, EventArgs e)
        {
         
            th = new Thread(tFunction);
            th.Start();
           
            
        }
        private void tFunction(object obj)
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["BeautyApp.Properties.Settings.SqlConnection"].ConnectionString;
           
            ILogInView view = new LogInView();
            ILogInRepository repository = new LogInRepository(sqlConnectionString);
            new LogInPresenter(view, repository, sqlConnectionString);
            view.AdminName = "";
            view.AdminPassword = "";
             Application.Run((Form) view);
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