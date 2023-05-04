using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautyApp.Models;
using BeautyApp.Presenters;
using BeautyApp.Repositories;
using BeautyApp.Views;
using System.Configuration;
namespace BeautyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["BeautyApp.Properties.Settings.SqlConnection"].ConnectionString;
            ILogInView view = new LogInView();
            ILogInRepository repository = new LogInRepository(sqlConnectionString);
            new LogInPresenter(view, repository, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
