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
        public MainView()
        {
            InitializeComponent();
            btnPets.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            btnEmployee.Click += delegate { ShowEmployeeView?.Invoke(this, EventArgs.Empty); };
            buttonCancel.Click += delegate { this.Close(); };
        }
        public event EventHandler ShowProductView;
        public event EventHandler ShowEmployeeView;
        //public event EventHandler ShowVetsView;
    }
}
