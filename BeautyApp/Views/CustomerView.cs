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
    public partial class CustomerView : Form, ICustomerView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        //Constructor
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlCustomer.TabPages.Remove(tabPageCustomerDetail);
            cbtnclose.Click += delegate { this.Close(); };



        }
        private void AssociateAndRaiseViewEvents()
        {
            cbtnsearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            ctxtsearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Others
            //Add new

            cbtnadd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabPageCustomerList);
                tabControlCustomer.TabPages.Add(tabPageCustomerDetail);
                tabPageCustomerDetail.Text = "Add new customer";
            };
            //Edit
            cbtnedit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabPageCustomerList);
                tabControlCustomer.TabPages.Add(tabPageCustomerDetail);
                tabPageCustomerDetail.Text = "Edit customer";
            };
            //Save changes
            cbtnsave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlCustomer.TabPages.Remove(tabPageCustomerDetail);
                    tabControlCustomer.TabPages.Add(tabPageCustomerList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            cbtncancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabPageCustomerDetail);
                tabControlCustomer.TabPages.Add(tabPageCustomerList);
            };
            cbtndelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected customer?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        //Properties
        public string CustomerId
        {
            get { return ctxtid.Text; }
            set { ctxtid.Text = value; }
        }

        public string CustomerName_
        {
            get { return ctxtname.Text; }
            set { ctxtname.Text = value; }
        }
        public string CustomerEmail
        {
            get { return ctxtemail.Text; }
            set { ctxtemail.Text = value; }
        }
        public string CustomerPhone
        {
            get { return ctxtphone.Text; }
            set { ctxtphone.Text = value; }
        }
        public string CustomerAddress////////////////////
        {
            get { return ctxtaddress.Text; }
            set { ctxtaddress.Text = value; }
        }
        public string SearchValue
        {
            get { return ctxtsearch.Text; }
            set { ctxtsearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
      
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
  
        //Methods
        public void SetProductListBindingSource(BindingSource customerList)
        {


            /* DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
             imgCol.HeaderText = "Images";
             imgCol.Image = new Bitmap(imageP);

             dataGridView.Columns.Add(imgCol);*/
            dataGridView1.DataSource = customerList;



            // dataGridView.Rows.Add(img);



        }

        private static CustomerView instance;
        public static CustomerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized) instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
