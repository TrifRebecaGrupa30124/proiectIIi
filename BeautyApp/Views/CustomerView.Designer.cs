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
            this.tabControlCustomer = new System.Windows.Forms.TabControl();
            this.tabPageCustomerDetail = new System.Windows.Forms.TabPage();
            this.tabPageCustomerList = new System.Windows.Forms.TabPage();
            this.ctxtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbtnclose = new System.Windows.Forms.Button();
            this.cbtndelete = new System.Windows.Forms.Button();
            this.cbtnedit = new System.Windows.Forms.Button();
            this.cbtnadd = new System.Windows.Forms.Button();
            this.cbtnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctxtid = new System.Windows.Forms.TextBox();
            this.ctxtphone = new System.Windows.Forms.TextBox();
            this.ctxtemail = new System.Windows.Forms.TextBox();
            this.ctxtname = new System.Windows.Forms.TextBox();
            this.ctxtaddress = new System.Windows.Forms.TextBox();
            this.cbtnsave = new System.Windows.Forms.Button();
            this.cbtncancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.tabControlCustomer.SuspendLayout();
            this.tabPageCustomerDetail.SuspendLayout();
            this.tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbtnclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 100);
            this.panel2.TabIndex = 0;
            // 
            // tabControlCustomer
            // 
            this.tabControlCustomer.Controls.Add(this.tabPageCustomerList);
            this.tabControlCustomer.Controls.Add(this.tabPageCustomerDetail);
            this.tabControlCustomer.Location = new System.Drawing.Point(0, 101);
            this.tabControlCustomer.Name = "tabControlCustomer";
            this.tabControlCustomer.SelectedIndex = 0;
            this.tabControlCustomer.Size = new System.Drawing.Size(963, 487);
            this.tabControlCustomer.TabIndex = 1;
            // 
            // tabPageCustomerDetail
            // 
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
            this.tabPageCustomerDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            this.tabPageCustomerDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerDetail.Size = new System.Drawing.Size(955, 458);
            this.tabPageCustomerDetail.TabIndex = 1;
            this.tabPageCustomerDetail.Text = "tabPage2";
            this.tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomerList
            // 
            this.tabPageCustomerList.Controls.Add(this.cbtndelete);
            this.tabPageCustomerList.Controls.Add(this.cbtnedit);
            this.tabPageCustomerList.Controls.Add(this.cbtnadd);
            this.tabPageCustomerList.Controls.Add(this.cbtnsearch);
            this.tabPageCustomerList.Controls.Add(this.dataGridView1);
            this.tabPageCustomerList.Controls.Add(this.ctxtsearch);
            this.tabPageCustomerList.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerList.Name = "tabPageCustomerList";
            this.tabPageCustomerList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerList.Size = new System.Drawing.Size(955, 458);
            this.tabPageCustomerList.TabIndex = 0;
            this.tabPageCustomerList.Text = "tabPage1";
            this.tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // ctxtsearch
            // 
            this.ctxtsearch.Location = new System.Drawing.Point(39, 33);
            this.ctxtsearch.Name = "ctxtsearch";
            this.ctxtsearch.Size = new System.Drawing.Size(329, 22);
            this.ctxtsearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(320, 245);
            this.dataGridView1.TabIndex = 1;
            // 
            // cbtnclose
            // 
            this.cbtnclose.Location = new System.Drawing.Point(739, 42);
            this.cbtnclose.Name = "cbtnclose";
            this.cbtnclose.Size = new System.Drawing.Size(75, 23);
            this.cbtnclose.TabIndex = 0;
            this.cbtnclose.Text = "Close";
            this.cbtnclose.UseVisualStyleBackColor = true;
            // 
            // cbtndelete
            // 
            this.cbtndelete.Location = new System.Drawing.Point(470, 376);
            this.cbtndelete.Name = "cbtndelete";
            this.cbtndelete.Size = new System.Drawing.Size(75, 23);
            this.cbtndelete.TabIndex = 2;
            this.cbtndelete.Text = "Delete";
            this.cbtndelete.UseVisualStyleBackColor = true;
            // 
            // cbtnedit
            // 
            this.cbtnedit.Location = new System.Drawing.Point(314, 376);
            this.cbtnedit.Name = "cbtnedit";
            this.cbtnedit.Size = new System.Drawing.Size(75, 23);
            this.cbtnedit.TabIndex = 3;
            this.cbtnedit.Text = "Edit";
            this.cbtnedit.UseVisualStyleBackColor = true;
            // 
            // cbtnadd
            // 
            this.cbtnadd.Location = new System.Drawing.Point(151, 376);
            this.cbtnadd.Name = "cbtnadd";
            this.cbtnadd.Size = new System.Drawing.Size(75, 23);
            this.cbtnadd.TabIndex = 4;
            this.cbtnadd.Text = "Add";
            this.cbtnadd.UseVisualStyleBackColor = true;
            // 
            // cbtnsearch
            // 
            this.cbtnsearch.Location = new System.Drawing.Point(422, 33);
            this.cbtnsearch.Name = "cbtnsearch";
            this.cbtnsearch.Size = new System.Drawing.Size(75, 23);
            this.cbtnsearch.TabIndex = 5;
            this.cbtnsearch.Text = "Search";
            this.cbtnsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // ctxtid
            // 
            this.ctxtid.Location = new System.Drawing.Point(137, 124);
            this.ctxtid.Name = "ctxtid";
            this.ctxtid.Size = new System.Drawing.Size(100, 22);
            this.ctxtid.TabIndex = 5;
            // 
            // ctxtphone
            // 
            this.ctxtphone.Location = new System.Drawing.Point(435, 192);
            this.ctxtphone.Name = "ctxtphone";
            this.ctxtphone.Size = new System.Drawing.Size(100, 22);
            this.ctxtphone.TabIndex = 6;
            // 
            // ctxtemail
            // 
            this.ctxtemail.Location = new System.Drawing.Point(137, 346);
            this.ctxtemail.Name = "ctxtemail";
            this.ctxtemail.Size = new System.Drawing.Size(100, 22);
            this.ctxtemail.TabIndex = 7;
            // 
            // ctxtname
            // 
            this.ctxtname.Location = new System.Drawing.Point(137, 230);
            this.ctxtname.Name = "ctxtname";
            this.ctxtname.Size = new System.Drawing.Size(100, 22);
            this.ctxtname.TabIndex = 8;
            // 
            // ctxtaddress
            // 
            this.ctxtaddress.Location = new System.Drawing.Point(435, 285);
            this.ctxtaddress.Name = "ctxtaddress";
            this.ctxtaddress.Size = new System.Drawing.Size(100, 22);
            this.ctxtaddress.TabIndex = 9;
            // 
            // cbtnsave
            // 
            this.cbtnsave.Location = new System.Drawing.Point(388, 380);
            this.cbtnsave.Name = "cbtnsave";
            this.cbtnsave.Size = new System.Drawing.Size(75, 23);
            this.cbtnsave.TabIndex = 10;
            this.cbtnsave.Text = "Save";
            this.cbtnsave.UseVisualStyleBackColor = true;
            // 
            // cbtncancel
            // 
            this.cbtncancel.Location = new System.Drawing.Point(513, 380);
            this.cbtncancel.Name = "cbtncancel";
            this.cbtncancel.Size = new System.Drawing.Size(75, 23);
            this.cbtncancel.TabIndex = 11;
            this.cbtncancel.Text = "Cancel";
            this.cbtncancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(660, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 250);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 600);
            this.Controls.Add(this.tabControlCustomer);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.panel2.ResumeLayout(false);
            this.tabControlCustomer.ResumeLayout(false);
            this.tabPageCustomerDetail.ResumeLayout(false);
            this.tabPageCustomerDetail.PerformLayout();
            this.tabPageCustomerList.ResumeLayout(false);
            this.tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}