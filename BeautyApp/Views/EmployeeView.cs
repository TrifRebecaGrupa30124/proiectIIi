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
    public partial class EmployeeView : Form, IEmployeeView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        //Constructor
        public EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            etabControl.TabPages.Remove(etabPage2);
            ebtnclose.Click += delegate { this.Close(); };



        }
        private void AssociateAndRaiseViewEvents()
        {
            ebtnsearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            etxtsearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Others
            //Add new


            ebtnadd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                etabControl.TabPages.Remove(etabPage1);
                etabControl.TabPages.Add(etabPage2);
                etabPage2.Text = "Add new employee";
            };
            //Edit
            ebtnedit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                etabControl.TabPages.Remove(etabPage1);
                etabControl.TabPages.Add(etabPage2);
                etabPage2.Text = "Edit employee";
            };
            //Save changes
            ebtnsave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    etabControl.TabPages.Remove(etabPage2);
                    etabControl.TabPages.Add(etabPage1);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            ebtncancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                etabControl.TabPages.Remove(etabPage2);
                etabControl.TabPages.Add(etabPage1);
            };
            ebtndelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected product?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        //Properties
        public string Id
        {
            get { return eIdtextBox.Text; }
            set { eIdtextBox.Text = value; }
        }
        public string EName
        {
            get { return eNametextBox.Text; }
            set { eNametextBox.Text = value; }
        }
        public string Email
        {
            get { return eEmailtextBox.Text; }
            set { eEmailtextBox.Text = value; }
        }
        public string Job_Name
        {
            get { return eJobtextBox.Text; }
            set { eJobtextBox.Text = value; }
        }
        public string Hire_Date
        {
            get { return eHiretextBox.Text; }
            set { eHiretextBox.Text = value; }
        }
        public string Salary////////////////////
        {
            get { return eSalarytextBox.Text; }
            set { eSalarytextBox.Text = value; }
        }
        public string Phone
        {
            get { return ePhonetextBox.Text; }
            set { ePhonetextBox.Text = value; }
        }
        public string Sex
        {
            get { return eSextextBox.Text; }
            set { eSextextBox.Text = value; }
        }
        public string Birth_Date
        {
            get { return eBirthtextBox.Text; }
            set { eBirthtextBox.Text = value; }
        }
        public string SearchValue
        {
            get { return etxtsearch.Text; }
            set { etxtsearch.Text = value; }
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
        public void SetProductListBindingSource(BindingSource petList)
        {
            edataGridView.DataSource = petList;
        }

        private static EmployeeView instance;
        public static EmployeeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EmployeeView();
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
