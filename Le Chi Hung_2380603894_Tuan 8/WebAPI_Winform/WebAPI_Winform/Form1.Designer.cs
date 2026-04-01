namespace WebAPI_Winform
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(399, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(421, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(14, 75);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.Size = new System.Drawing.Size(734, 213);
            this.dgvBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(123, 301);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(267, 22);
            this.txtTitle.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(123, 333);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(267, 22);
            this.txtPrice.TabIndex = 15;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(123, 365);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(107, 22);
            this.txtCategoryId.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(12, 305);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Tiêu đề:";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(12, 337);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 25);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Giá:";
            // 
            // lblCat
            // 
            this.lblCat.Location = new System.Drawing.Point(12, 369);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(114, 25);
            this.lblCat.TabIndex = 11;
            this.lblCat.Text = "Mã loại:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(463, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 53);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm sách mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 505);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Quản lý Sách qua Web API - Port 9999";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            private System.Windows.Forms.TextBox txtSearch;
            private System.Windows.Forms.Button btnSearch;
            private System.Windows.Forms.DataGridView dgvBooks;
            private System.Windows.Forms.TextBox txtTitle;
            private System.Windows.Forms.TextBox txtPrice;
            private System.Windows.Forms.TextBox txtCategoryId;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblPrice;
            private System.Windows.Forms.Label lblCat;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Label label1;
    }
}

