using BeautyApp.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
    public partial class LogInView : Form, ILogInView
    {
        Thread th;
        public LogInView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string Admin_Id
        {
            get { return textBoxId.Text; }
            set { textBoxId.Text = value; }
        }
        public string AdminName
        {
            get { return textBoxUserName.Text; }
            set { textBoxUserName.Text = value; }
        }
        public string AdminPassword
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }
        public event EventHandler LogInEvent;

        private void AssociateAndRaiseViewEvents()
        {
            buttonLogIn.Click += delegate
            {
                LogInEvent?.Invoke(this, EventArgs.Empty);
             
            };
        }
       
    }
}
