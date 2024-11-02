namespace WindowsForm_Bài_kiểm_tra_số_2
{
    partial class Form1
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
            this.dataSanpham = new System.Windows.Forms.DataGridView();
            this.dtTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.data_giohang = new System.Windows.Forms.DataGridView();
            this.gio_tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gio_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gio_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_giohang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSanpham
            // 
            this.dataSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtTensp,
            this.dtgiasp,
            this.dtsoluong,
            this.dtanh});
            this.dataSanpham.Location = new System.Drawing.Point(35, 44);
            this.dataSanpham.Name = "dataSanpham";
            this.dataSanpham.Size = new System.Drawing.Size(443, 270);
            this.dataSanpham.TabIndex = 0;
            // 
            // dtTensp
            // 
            this.dtTensp.DataPropertyName = "Name";
            this.dtTensp.HeaderText = "Tên sản phẩm";
            this.dtTensp.Name = "dtTensp";
            // 
            // dtgiasp
            // 
            this.dtgiasp.DataPropertyName = "Price";
            this.dtgiasp.HeaderText = "Giá sản phẩm";
            this.dtgiasp.Name = "dtgiasp";
            // 
            // dtsoluong
            // 
            this.dtsoluong.DataPropertyName = "Quantity";
            this.dtsoluong.HeaderText = "Số lượng";
            this.dtsoluong.Name = "dtsoluong";
            // 
            // dtanh
            // 
            this.dtanh.DataPropertyName = "Image";
            this.dtanh.HeaderText = "Hình ảnh";
            this.dtanh.Name = "dtanh";
            this.dtanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(518, 44);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 46);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(644, 44);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(87, 46);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // data_giohang
            // 
            this.data_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_giohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gio_tensp,
            this.gio_gia,
            this.gio_soluong});
            this.data_giohang.Location = new System.Drawing.Point(518, 202);
            this.data_giohang.Name = "data_giohang";
            this.data_giohang.Size = new System.Drawing.Size(338, 252);
            this.data_giohang.TabIndex = 3;
            // 
            // gio_tensp
            // 
            this.gio_tensp.DataPropertyName = "Name";
            this.gio_tensp.HeaderText = "Tên sản phẩm";
            this.gio_tensp.Name = "gio_tensp";
            // 
            // gio_gia
            // 
            this.gio_gia.DataPropertyName = "Price";
            this.gio_gia.HeaderText = "Giá sản phẩm";
            this.gio_gia.Name = "gio_gia";
            // 
            // gio_soluong
            // 
            this.gio_soluong.DataPropertyName = "Quantity";
            this.gio_soluong.HeaderText = "số lượng";
            this.gio_soluong.Name = "gio_soluong";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(876, 336);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(159, 20);
            this.txt_tongtien.TabIndex = 4;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(894, 386);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(104, 39);
            this.btn_thanhtoan.TabIndex = 5;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(873, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giỏ hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.data_giohang);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataSanpham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_giohang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView data_giohang;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.DataGridView dataSanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgiasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtsoluong;
        private System.Windows.Forms.DataGridViewImageColumn dtanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio_tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio_soluong;
    }
}

