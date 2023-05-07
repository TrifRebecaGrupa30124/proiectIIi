namespace BeautyApp.Views
{
    partial class CustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbtnclose = new System.Windows.Forms.Button();
            this.tabControlCustomer = new System.Windows.Forms.TabControl();
            this.tabPageCustomerList = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtndelete = new System.Windows.Forms.Button();
            this.cbtnedit = new System.Windows.Forms.Button();
            this.cbtnadd = new System.Windows.Forms.Button();
            this.cbtnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctxtsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageCustomerDetail = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbtncancel = new System.Windows.Forms.Button();
            this.cbtnsave = new System.Windows.Forms.Button();
            this.ctxtaddress = new System.Windows.Forms.TextBox();
            this.ctxtname = new System.Windows.Forms.TextBox();
            this.ctxtemail = new System.Windows.Forms.TextBox();
            this.ctxtphone = new System.Windows.Forms.TextBox();
            this.ctxtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tabControlCustomer.SuspendLayout();
            this.tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbtnclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 100);
            this.panel2.TabIndex = 0;
            // 
            // cbtnclose
            // 
            this.cbtnclose.BackColor = System.Drawing.Color.DeepPink;
            this.cbtnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtnclose.ForeColor = System.Drawing.Color.White;
            this.cbtnclose.Location = new System.Drawing.Point(1061, 12);
            this.cbtnclose.Name = "cbtnclose";
            this.cbtnclose.Size = new System.Drawing.Size(105, 36);
            this.cbtnclose.TabIndex = 0;
            this.cbtnclose.Text = "Close";
            this.cbtnclose.UseVisualStyleBackColor = false;
            // 
            // tabControlCustomer
            // 
            this.tabControlCustomer.Controls.Add(this.tabPageCustomerList);
            this.tabControlCustomer.Controls.Add(this.tabPageCustomerDetail);
            this.tabControlCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCustomer.Location = new System.Drawing.Point(0, 101);
            this.tabControlCustomer.Name = "tabControlCustomer";
            this.tabControlCustomer.SelectedIndex = 0;
            this.tabControlCustomer.Size = new System.Drawing.Size(1283, 691);
            this.tabControlCustomer.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            this.tabPageCustomerList.Controls.Add(this.label10);
            this.tabPageCustomerList.Controls.Add(this.cbtndelete);
            this.tabPageCustomerList.Controls.Add(this.cbtnedit);
            this.tabPageCustomerList.Controls.Add(this.cbtnadd);
            this.tabPageCustomerList.Controls.Add(this.cbtnsearch);
            this.tabPageCustomerList.Controls.Add(this.dataGridView1);
            this.tabPageCustomerList.Controls.Add(this.ctxtsearch);
            this.tabPageCustomerList.Controls.Add(this.pictureBox1);
            this.tabPageCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCustomerList.Location = new System.Drawing.Point(4, 31);
            this.tabPageCustomerList.Name = "tabPageCustomerList";
            this.tabPageCustomerList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerList.Size = new System.Drawing.Size(1275, 656);
            this.tabPageCustomerList.TabIndex = 0;
            this.tabPageCustomerList.Text = "Show Customers";
            this.tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(542, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 38);
            this.label10.TabIndex = 12;
            this.label10.Text = "Customers";
            // 
            // cbtndelete
            // 
            this.cbtndelete.Location = new System.Drawing.Point(873, 418);
            this.cbtndelete.Name = "cbtndelete";
            this.cbtndelete.Size = new System.Drawing.Size(93, 32);
            this.cbtndelete.TabIndex = 2;
            this.cbtndelete.Text = "Delete";
            this.cbtndelete.UseVisualStyleBackColor = true;
            // 
            // cbtnedit
            // 
            this.cbtnedit.Location = new System.Drawing.Point(606, 418);
            this.cbtnedit.Name = "cbtnedit";
            this.cbtnedit.Size = new System.Drawing.Size(92, 32);
            this.cbtnedit.TabIndex = 3;
            this.cbtnedit.Text = "Edit";
            this.cbtnedit.UseVisualStyleBackColor = true;
            // 
            // cbtnadd
            // 
            this.cbtnadd.Location = new System.Drawing.Point(371, 418);
            this.cbtnadd.Name = "cbtnadd";
            this.cbtnadd.Size = new System.Drawing.Size(92, 32);
            this.cbtnadd.TabIndex = 4;
            this.cbtnadd.Text = "Add";
            this.cbtnadd.UseVisualStyleBackColor = true;
            // 
            // cbtnsearch
            // 
            this.cbtnsearch.Location = new System.Drawing.Point(948, 93);
            this.cbtnsearch.Name = "cbtnsearch";
            this.cbtnsearch.Size = new System.Drawing.Size(95, 34);
            this.cbtnsearch.TabIndex = 5;
            this.cbtnsearch.Text = "Search";
            this.cbtnsearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 245);
            this.dataGridView1.TabIndex = 1;
            // 
            // ctxtsearch
            // 
            this.ctxtsearch.Location = new System.Drawing.Point(336, 93);
            this.ctxtsearch.Name = "ctxtsearch";
            this.ctxtsearch.Size = new System.Drawing.Size(584, 28);
            this.ctxtsearch.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautyApp.Properties.Resources.set_people_shopping_people_with_shopping_bags_vector_illustration_77417_2885_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(57, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1185, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageCustomerDetail
            // 
            this.tabPageCustomerDetail.Controls.Add(this.pictureBox3);
            this.tabPageCustomerDetail.Controls.Add(this.pictureBox2);
            this.tabPageCustomerDetail.Controls.Add(this.cbtncancel);
            this.tabPageCustomerDetail.Controls.Add(this.cbtnsave);
            this.tabPageCustomerDetail.Controls.Add(this.ctxtaddress);
            this.tabPageCustomerDetail.Controls.Add(this.ctxtname);
            this.tabPageCustomerDetail.Controls.Add(this.ctxtemail);
            this.tabPageCustomerDetail.Controls.Add(this.ctxtphone);
            this.tabPageCustomerDetail.Controls.Add(this.ctxtid);
            this.tabPageCustomerDetail.Controls.Add(this.label5);
            this.tabPageCustomerDetail.Controls.Add(this.label4);
            this.tabPageCustomerDetail.Controls.Add(this.label3);
            this.tabPageCustomerDetail.Controls.Add(this.label2);
            this.tabPageCustomerDetail.Controls.Add(this.label1);
            this.tabPageCustomerDetail.Location = new System.Drawing.Point(4, 31);
            this.tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            this.tabPageCustomerDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerDetail.Size = new System.Drawing.Size(1275, 656);
            this.tabPageCustomerDetail.TabIndex = 1;
            this.tabPageCustomerDetail.Text = "Modify Customers";
            this.tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BeautyApp.Properties.Resources.customer_base_marketing_2_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(680, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(385, 335);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(680, 569);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 51);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // cbtncancel
            // 
            this.cbtncancel.Location = new System.Drawing.Point(657, 464);
            this.cbtncancel.Name = "cbtncancel";
            this.cbtncancel.Size = new System.Drawing.Size(90, 36);
            this.cbtncancel.TabIndex = 11;
            this.cbtncancel.Text = "Cancel";
            this.cbtncancel.UseVisualStyleBackColor = true;
            // 
            // cbtnsave
            // 
            this.cbtnsave.Location = new System.Drawing.Point(307, 465);
            this.cbtnsave.Name = "cbtnsave";
            this.cbtnsave.Size = new System.Drawing.Size(90, 35);
            this.cbtnsave.TabIndex = 10;
            this.cbtnsave.Text = "Save";
            this.cbtnsave.UseVisualStyleBackColor = true;
            // 
            // ctxtaddress
            // 
            this.ctxtaddress.Location = new System.Drawing.Point(453, 330);
            this.ctxtaddress.Name = "ctxtaddress";
            this.ctxtaddress.Size = new System.Drawing.Size(193, 28);
            this.ctxtaddress.TabIndex = 9;
            // 
            // ctxtname
            // 
            this.ctxtname.Location = new System.Drawing.Point(453, 220);
            this.ctxtname.Name = "ctxtname";
            this.ctxtname.Size = new System.Drawing.Size(193, 28);
            this.ctxtname.TabIndex = 8;
            // 
            // ctxtemail
            // 
            this.ctxtemail.Location = new System.Drawing.Point(453, 274);
            this.ctxtemail.Name = "ctxtemail";
            this.ctxtemail.Size = new System.Drawing.Size(193, 28);
            this.ctxtemail.TabIndex = 7;
            // 
            // ctxtphone
            // 
            this.ctxtphone.Location = new System.Drawing.Point(453, 392);
            this.ctxtphone.Name = "ctxtphone";
            this.ctxtphone.Size = new System.Drawing.Size(193, 28);
            this.ctxtphone.TabIndex = 6;
            // 
            // ctxtid
            // 
            this.ctxtid.Location = new System.Drawing.Point(453, 165);
            this.ctxtid.Name = "ctxtid";
            this.ctxtid.ReadOnly = true;
            this.ctxtid.Size = new System.Drawing.Size(193, 28);
            this.ctxtid.TabIndex = 5;
            this.ctxtid.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 811);
            this.Controls.Add(this.tabControlCustomer);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.panel2.ResumeLayout(false);
            this.tabControlCustomer.ResumeLayout(false);
            this.tabPageCustomerList.ResumeLayout(false);
            this.tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageCustomerDetail.ResumeLayout(false);
            this.tabPageCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControlCustomer;
        private System.Windows.Forms.TabPage tabPageCustomerDetail;
        private System.Windows.Forms.TabPage tabPageCustomerList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ctxtsearch;
        private System.Windows.Forms.Button cbtnclose;
        private System.Windows.Forms.Button cbtndelete;
        private System.Windows.Forms.Button cbtnedit;
        private System.Windows.Forms.Button cbtnadd;
        private System.Windows.Forms.Button cbtnsearch;
        private System.Windows.Forms.TextBox ctxtaddress;
        private System.Windows.Forms.TextBox ctxtname;
        private System.Windows.Forms.TextBox ctxtemail;
        private System.Windows.Forms.TextBox ctxtphone;
        private System.Windows.Forms.TextBox ctxtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cbtncancel;
        private System.Windows.Forms.Button cbtnsave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}