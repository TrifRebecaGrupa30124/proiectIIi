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

    public partial class BasketView : Form, IBasketView
    {
        //Fields
        private string message;
        private bool isSuccessful;

        //Constructor
        public BasketView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            bbtnclose.Click += delegate { this.Close(); };



        }
        private void AssociateAndRaiseViewEvents()
        {


            // dataGridView1.Click += delegate { CurrentEvent?.Invoke(this, EventArgs.Empty); };
            bbtnprint.Click += delegate
            {
                PrintEvent?.Invoke(this, EventArgs.Empty);

            };
            //Edit



            bbtndelete.Click += delegate
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
        /*  public string ProductId
          {
              get { return txtProductId.Text; }
              set { txtProductId.Text = value; }
          }

          public string ProductName_
          {
              get { return txtProductName.Text; }
              set { txtProductName.Text = value; }
          }

          public string ProductPrice
          {
              get { return txtProductPrice.Text; }
              set { txtProductPrice.Text = value; }
          }
           public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
         */

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


        public event EventHandler PrintEvent;
        public event EventHandler SelectProductEvent;
        public event EventHandler SelectCustomerEvent;

        public event EventHandler DeleteEvent;
        //Methods
        public void SetProductListBindingSource(BindingSource petList, BindingSource petList1, BindingSource petList2)
        {


            /* DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
             imgCol.HeaderText = "Images";
             imgCol.Image = new Bitmap(imageP);

             dataGridView.Columns.Add(imgCol);*/
            dataGridView1.DataSource = petList;

            dataGridView2.DataSource = petList1;

            dataGridView3.DataSource = petList2;


            // dataGridView.Rows.Add(img);



        }

        private static BasketView instance;
        public static BasketView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BasketView();
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