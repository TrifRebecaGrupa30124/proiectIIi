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
            dataGridView2.Click += delegate {

                CurrentEvent?.Invoke(this, EventArgs.Empty);
                this.Update();
            };

            dataGridView3.Click += delegate {

                SelectCustomerEvent?.Invoke(this, EventArgs.Empty);
                this.Update();
            };


            bbtndelete.Click += delegate
            {
               
                
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
               
            };
        }

        //Properties
        public string CustomerName
        {
            get { return ctxtname.Text; }
            set { ctxtname.Text = value; }
        }

        public string CustomerPhone
        {
            get { return ctxtphone.Text; }
            set { ctxtphone.Text = value; }
        }

        public string CustomerAddress
        {
            get { return ctxtaddress.Text; }
            set { ctxtaddress.Text = value; }
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


        public event EventHandler PrintEvent;
        public event EventHandler SelectProductEvent;
        public event EventHandler SelectCustomerEvent;
        public event EventHandler CurrentEvent;
        public event EventHandler CurrentEventCustomer;

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
        void StyleDataGridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepPink;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void BasketView_Load(object sender, EventArgs e)
        {
            StyleDataGridview();
        }
    }


}