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
    public partial class ProductView : Form, IProductView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        //Constructor
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlPet.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };



        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Others
            //Add new

            dataGridView.Click += delegate { CurrentEvent?.Invoke(this, EventArgs.Empty); };
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControlPet.TabPages.Remove(tabPagePetList);
                tabControlPet.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add new product";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlPet.TabPages.Remove(tabPagePetList);
                tabControlPet.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Edit product";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlPet.TabPages.Remove(tabPagePetDetail);
                    tabControlPet.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlPet.TabPages.Remove(tabPagePetDetail);
                tabControlPet.TabPages.Add(tabPagePetList);
            };
            btnDelete.Click += delegate
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
        public string ProductId
        {
            get { return txtProductId.Text; }
            set { txtProductId.Text = value; }
        }
      
        public string ProductName_
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public string ProductDescription
        {
            get { return txtProductDescription.Text; }
            set { txtProductDescription.Text = value; }
        }
        public string ProductPrice
        {
            get { return txtProductPrice.Text; }
            set { txtProductPrice.Text = value; }
        }
        public string ProductAmmount////////////////////
        {
            get { return txtProductPrice.Text; }
            set { textProductAmmount.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
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
        public Bitmap ProductImage
        {
            get
            {
                return new Bitmap(pictureBox1.Image);

            }
            set
            {
                pictureBox1.Image = value;

            }
        }
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler CurrentEvent;
        //Methods
        public void SetProductListBindingSource(BindingSource petList)
        {


           /* DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Images";
            imgCol.Image = new Bitmap(imageP);

            dataGridView.Columns.Add(imgCol);*/
            dataGridView.DataSource = petList;
          
            

            // dataGridView.Rows.Add(img);
           


        }

        private static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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
