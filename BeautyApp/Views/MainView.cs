using AIMLbot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyApp.Views
{
    public partial class MainView : Form, IMainView
    {
        HomeView view;
        public MainView()
        {
            InitializeComponent();

            btnPets.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            btnbasket.Click += delegate { ShowBasketView?.Invoke(this, EventArgs.Empty); };
            btnEmployee.Click += delegate { ShowEmployeeView?.Invoke(this, EventArgs.Empty); };
            btnCustomers.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
            buttonLogOut.Click += delegate {
                this.Close();
                LogOut?.Invoke(this, EventArgs.Empty);
            };
            buttonCancel.Click += delegate { this.Close(); };
            this.Activated += delegate {

                panel3.Visible = false;
                ; ShowHomeView?.Invoke(this, EventArgs.Empty);
            };
            int t = 0;
            button2.Click += delegate {

                ChatBot?.Invoke(this, EventArgs.Empty);
            };

            button1.Click += delegate {
                t++;
                if (t % 2 == 1) panel3.Visible = true;
                else panel3.Visible = false;
            };



        }
        public string Answer
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        public string Question
        {
            get { return textBoxQuestion.Text; }
            set { textBoxQuestion.Text = value; }
        }
        public string QuestionLabel
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public event EventHandler ShowProductView;
        public event EventHandler ShowEmployeeView;
        public event EventHandler ShowCustomerView;
        public event EventHandler LogOut;
        public event EventHandler ShowBasketView;
        public event EventHandler ShowHomeView;
        public event EventHandler ChatBot;
        //public event EventHandler ShowVetsView;
    }
}