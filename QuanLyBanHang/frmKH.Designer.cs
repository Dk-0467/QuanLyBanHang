﻿namespace QuanLyBanHang
{
    partial class frmKH
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKH));
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.radioBtnNu = new System.Windows.Forms.RadioButton();
			this.radioBtnNam = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.Location = new System.Drawing.Point(32, 202);
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.RowHeadersWidth = 51;
			this.dgvKhachHang.Size = new System.Drawing.Size(714, 229);
			this.dgvKhachHang.TabIndex = 16;
			this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
			// 
			// txtTenKH
			// 
			this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenKH.Location = new System.Drawing.Point(528, 104);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(220, 24);
			this.txtTenKH.TabIndex = 1;
			this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
			// 
			// txtMaKH
			// 
			this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaKH.Location = new System.Drawing.Point(147, 104);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(220, 24);
			this.txtMaKH.TabIndex = 0;
			this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label3.Location = new System.Drawing.Point(412, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Tên khách hàng";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label2.Location = new System.Drawing.Point(31, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Mã khách hàng";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
			this.label1.Location = new System.Drawing.Point(186, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 45);
			this.label1.TabIndex = 11;
			this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSkip);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnEdit);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(32, 437);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(714, 62);
			this.panel2.TabIndex = 10;
			// 
			// btnSkip
			// 
			this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.btnSkip.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_skippng;
			this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSkip.Location = new System.Drawing.Point(378, 14);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(91, 35);
			this.btnSkip.TabIndex = 4;
			this.btnSkip.Text = "Bỏ qua";
			this.btnSkip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSkip.UseVisualStyleBackColor = true;
			this.btnSkip.Click += new System.EventHandler(this.btnBoQua_Click);
			// 
			// btnExit
			// 
			this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.btnExit.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_exit_png1;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(636, 14);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(76, 35);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Đóng";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnSave
			// 
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.btnSave.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_savepng;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(513, 14);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(79, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.btnEdit.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_editpng;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(135, 14);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(79, 35);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.btnDelete.Image = global::QuanLyBanHang.Properties.Resources.icons8_delete_32;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(258, 14);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(76, 35);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.btnAdd.Image = global::QuanLyBanHang.Properties.Resources.add__1_;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(0, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(91, 35);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtSDT
			// 
			this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(147, 137);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(220, 24);
			this.txtSDT.TabIndex = 5;
			this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(528, 138);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(220, 24);
			this.txtDiaChi.TabIndex = 4;
			this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label4.Location = new System.Drawing.Point(31, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 17);
			this.label4.TabIndex = 20;
			this.label4.Text = "Số điện thoại";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label5.Location = new System.Drawing.Point(412, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 17);
			this.label5.TabIndex = 18;
			this.label5.Text = "Địa chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label6.Location = new System.Drawing.Point(31, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 17);
			this.label6.TabIndex = 21;
			this.label6.Text = "Giới tính";
			// 
			// radioBtnNu
			// 
			this.radioBtnNu.AutoSize = true;
			this.radioBtnNu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBtnNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.radioBtnNu.Location = new System.Drawing.Point(274, 172);
			this.radioBtnNu.Name = "radioBtnNu";
			this.radioBtnNu.Size = new System.Drawing.Size(47, 24);
			this.radioBtnNu.TabIndex = 3;
			this.radioBtnNu.TabStop = true;
			this.radioBtnNu.Text = "Nữ";
			this.radioBtnNu.UseVisualStyleBackColor = true;
			// 
			// radioBtnNam
			// 
			this.radioBtnNam.AutoSize = true;
			this.radioBtnNam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBtnNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.radioBtnNam.Location = new System.Drawing.Point(147, 172);
			this.radioBtnNam.Name = "radioBtnNam";
			this.radioBtnNam.Size = new System.Drawing.Size(59, 24);
			this.radioBtnNam.TabIndex = 2;
			this.radioBtnNam.TabStop = true;
			this.radioBtnNam.Text = "Nam";
			this.radioBtnNam.UseVisualStyleBackColor = true;
			// 
			// frmKH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
			this.ClientSize = new System.Drawing.Size(784, 511);
			this.Controls.Add(this.radioBtnNu);
			this.Controls.Add(this.radioBtnNam);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSDT);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgvKhachHang);
			this.Controls.Add(this.txtTenKH);
			this.Controls.Add(this.txtMaKH);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 550);
			this.MinimumSize = new System.Drawing.Size(800, 550);
			this.Name = "frmKH";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách khách hàng";
			this.Load += new System.EventHandler(this.frmKhachHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBtnNu;
        private System.Windows.Forms.RadioButton radioBtnNam;
        private System.Windows.Forms.Button btnSkip;
    }
}