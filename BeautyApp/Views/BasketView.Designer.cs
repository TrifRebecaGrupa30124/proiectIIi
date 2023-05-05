namespace BeautyApp.Views
{
    partial class BasketView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bbtndelete = new System.Windows.Forms.Button();
            this.bbtnprint = new System.Windows.Forms.Button();
            this.ctxtname = new System.Windows.Forms.TextBox();
            this.ctxtphone = new System.Windows.Forms.TextBox();
            this.ctxtaddress = new System.Windows.Forms.TextBox();
            this.bbtnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(580, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(389, 199);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(536, 419);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(463, 199);
            this.dataGridView3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctxtaddress);
            this.panel1.Controls.Add(this.ctxtphone);
            this.panel1.Controls.Add(this.ctxtname);
            this.panel1.Location = new System.Drawing.Point(94, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 134);
            this.panel1.TabIndex = 3;
            // 
            // bbtndelete
            // 
            this.bbtndelete.Location = new System.Drawing.Point(668, 340);
            this.bbtndelete.Name = "bbtndelete";
            this.bbtndelete.Size = new System.Drawing.Size(75, 23);
            this.bbtndelete.TabIndex = 4;
            this.bbtndelete.Text = "Delete";
            this.bbtndelete.UseVisualStyleBackColor = true;
            // 
            // bbtnprint
            // 
            this.bbtnprint.Location = new System.Drawing.Point(806, 340);
            this.bbtnprint.Name = "bbtnprint";
            this.bbtnprint.Size = new System.Drawing.Size(75, 23);
            this.bbtnprint.TabIndex = 5;
            this.bbtnprint.Text = "Print";
            this.bbtnprint.UseVisualStyleBackColor = true;
            // 
            // ctxtname
            // 
            this.ctxtname.Location = new System.Drawing.Point(22, 18);
            this.ctxtname.Name = "ctxtname";
            this.ctxtname.Size = new System.Drawing.Size(100, 22);
            this.ctxtname.TabIndex = 0;
            // 
            // ctxtphone
            // 
            this.ctxtphone.Location = new System.Drawing.Point(140, 18);
            this.ctxtphone.Name = "ctxtphone";
            this.ctxtphone.Size = new System.Drawing.Size(100, 22);
            this.ctxtphone.TabIndex = 1;
            // 
            // ctxtaddress
            // 
            this.ctxtaddress.Location = new System.Drawing.Point(262, 18);
            this.ctxtaddress.Name = "ctxtaddress";
            this.ctxtaddress.Size = new System.Drawing.Size(100, 22);
            this.ctxtaddress.TabIndex = 2;
            // 
            // bbtnclose
            // 
            this.bbtnclose.Location = new System.Drawing.Point(791, 43);
            this.bbtnclose.Name = "bbtnclose";
            this.bbtnclose.Size = new System.Drawing.Size(75, 23);
            this.bbtnclose.TabIndex = 6;
            this.bbtnclose.Text = "close";
            this.bbtnclose.UseVisualStyleBackColor = true;
            // 
            // BasketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 658);
            this.Controls.Add(this.bbtnclose);
            this.Controls.Add(this.bbtnprint);
            this.Controls.Add(this.bbtndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BasketView";
            this.Text = "BasketView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bbtndelete;
        private System.Windows.Forms.Button bbtnprint;
        private System.Windows.Forms.TextBox ctxtaddress;
        private System.Windows.Forms.TextBox ctxtphone;
        private System.Windows.Forms.TextBox ctxtname;
        private System.Windows.Forms.Button bbtnclose;
    }
}