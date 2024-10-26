namespace QuanLyBanHang
{
    partial class frmSP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSP));
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnSeach = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboMaNhaCungCap = new System.Windows.Forms.ComboBox();
			this.txtDonGiaBan = new System.Windows.Forms.TextBox();
			this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
			this.txtTenSanPham = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaSanPham = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Location = new System.Drawing.Point(12, 197);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.RowHeadersWidth = 51;
			this.dgvSanPham.Size = new System.Drawing.Size(778, 263);
			this.dgvSanPham.TabIndex = 7;
			this.dgvSanPham.Click += new System.EventHandler(this.dgvSanPham_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.btnSkip);
			this.panel2.Controls.Add(this.btnSeach);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnEdit);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(12, 466);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(778, 67);
			this.panel2.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(698, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 35);
			this.button1.TabIndex = 8;
			this.button1.Text = "Xuất Excel";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSkip
			// 
			this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSkip.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_skippng3;
			this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSkip.Location = new System.Drawing.Point(302, 16);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(93, 35);
			this.btnSkip.TabIndex = 4;
			this.btnSkip.Text = "Bỏ qua";
			this.btnSkip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSkip.UseVisualStyleBackColor = true;
			this.btnSkip.Click += new System.EventHandler(this.btnBoQua_Click);
			// 
			// btnSeach
			// 
			this.btnSeach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeach.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_searchpng;
			this.btnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSeach.Location = new System.Drawing.Point(604, 16);
			this.btnSeach.Name = "btnSeach";
			this.btnSeach.Size = new System.Drawing.Size(80, 35);
			this.btnSeach.TabIndex = 5;
			this.btnSeach.Text = "Tìm";
			this.btnSeach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSeach.UseVisualStyleBackColor = true;
			this.btnSeach.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_exit_png4;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(507, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(81, 35);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Đóng";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_savepng3;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(411, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_editpng3;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(109, 16);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(80, 35);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = global::QuanLyBanHang.Properties.Resources.icons8_delete_32;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(205, 16);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(81, 35);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = global::QuanLyBanHang.Properties.Resources.add__1_;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(0, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(93, 35);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
			this.label1.Location = new System.Drawing.Point(193, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(395, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "DANH SÁCH SẢN PHẨM";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cboMaNhaCungCap);
			this.panel1.Controls.Add(this.txtDonGiaBan);
			this.panel1.Controls.Add(this.txtDonGiaNhap);
			this.panel1.Controls.Add(this.txtTenSanPham);
			this.panel1.Controls.Add(this.txtSoLuong);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtMaSanPham);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(12, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(778, 110);
			this.panel1.TabIndex = 4;
			// 
			// cboMaNhaCungCap
			// 
			this.cboMaNhaCungCap.FormattingEnabled = true;
			this.cboMaNhaCungCap.Location = new System.Drawing.Point(533, 9);
			this.cboMaNhaCungCap.Name = "cboMaNhaCungCap";
			this.cboMaNhaCungCap.Size = new System.Drawing.Size(229, 26);
			this.cboMaNhaCungCap.TabIndex = 1;
			// 
			// txtDonGiaBan
			// 
			this.txtDonGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDonGiaBan.Location = new System.Drawing.Point(533, 70);
			this.txtDonGiaBan.Name = "txtDonGiaBan";
			this.txtDonGiaBan.Size = new System.Drawing.Size(228, 24);
			this.txtDonGiaBan.TabIndex = 5;
			// 
			// txtDonGiaNhap
			// 
			this.txtDonGiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDonGiaNhap.Location = new System.Drawing.Point(533, 40);
			this.txtDonGiaNhap.Name = "txtDonGiaNhap";
			this.txtDonGiaNhap.Size = new System.Drawing.Size(228, 24);
			this.txtDonGiaNhap.TabIndex = 4;
			// 
			// txtTenSanPham
			// 
			this.txtTenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenSanPham.Location = new System.Drawing.Point(122, 40);
			this.txtTenSanPham.Name = "txtTenSanPham";
			this.txtTenSanPham.Size = new System.Drawing.Size(236, 24);
			this.txtTenSanPham.TabIndex = 2;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSoLuong.Location = new System.Drawing.Point(122, 70);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(236, 24);
			this.txtSoLuong.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(415, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mã nhà cung cấp";
			// 
			// txtMaSanPham
			// 
			this.txtMaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaSanPham.Location = new System.Drawing.Point(122, 11);
			this.txtMaSanPham.Name = "txtMaSanPham";
			this.txtMaSanPham.Size = new System.Drawing.Size(236, 24);
			this.txtMaSanPham.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(415, 43);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 17);
			this.label7.TabIndex = 5;
			this.label7.Text = "Đơn giá nhập";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(415, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "Đơn giá bán";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(3, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "Số lượng";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(3, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tên sản phẩm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(3, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã sản phẩm";
			// 
			// frmSP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
			this.ClientSize = new System.Drawing.Size(804, 541);
			this.Controls.Add(this.dgvSanPham);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(968, 638);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "frmSP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách sản phẩm";
			this.Load += new System.EventHandler(this.frmSanPham_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.ComboBox cboMaNhaCungCap;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSeach;
	}
}