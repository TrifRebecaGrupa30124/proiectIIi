using BeautyApp.Models;
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
    class LogInPresenter 
    {
        Thread th;
        private readonly string sqlConnectionString;
        private ILogInView view;
        private ILogInRepository repository;
        public bool valid = false;

        public LogInPresenter(ILogInView view, ILogInRepository repository, string sqlConnectionString)
        {
            this.view = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.view.LogInEvent += VerifyAdmin;
        }

        private void VerifyAdmin(object sender, EventArgs e)
        {
            ModelLogIn m = (ModelLogIn)repository.GetAll();
            if (m.Id == Convert.ToInt32(view.Admin_Id) && m.Name == view.AdminName && m.Password == view.AdminPassword)
            {
                LogInView.ActiveForm.Close();

                th = new Thread(tFunction);
                th.Start();

            }
            else MessageBox.Show("User name/password incorrect or is missing", "Warning",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }
       
        private void tFunction(object obj)
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["BeautyApp.Properties.Settings.SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
            // Application.Run(new MainView());
        }



    }

}