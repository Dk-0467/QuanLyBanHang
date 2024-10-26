namespace QuanLyBanHang
{
    partial class frmNCC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenNhaCC = new System.Windows.Forms.TextBox();
			this.txtMaNhaCC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
			this.SuspendLayout();
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
			this.panel2.Location = new System.Drawing.Point(15, 390);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(763, 59);
			this.panel2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
			this.label1.Location = new System.Drawing.Point(272, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "NHÀ CUNG CẤP";
			// 
			// txtTenNhaCC
			// 
			this.txtTenNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNhaCC.Location = new System.Drawing.Point(516, 103);
			this.txtTenNhaCC.Name = "txtTenNhaCC";
			this.txtTenNhaCC.Size = new System.Drawing.Size(250, 24);
			this.txtTenNhaCC.TabIndex = 1;
			// 
			// txtMaNhaCC
			// 
			this.txtMaNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNhaCC.Location = new System.Drawing.Point(131, 103);
			this.txtMaNhaCC.Name = "txtMaNhaCC";
			this.txtMaNhaCC.Size = new System.Drawing.Size(250, 24);
			this.txtMaNhaCC.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(394, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tên nhà cung cấp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mã nhà cung cấp";
			// 
			// dgvNhaCungCap
			// 
			this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhaCungCap.Location = new System.Drawing.Point(15, 149);
			this.dgvNhaCungCap.Name = "dgvNhaCungCap";
			this.dgvNhaCungCap.RowHeadersWidth = 51;
			this.dgvNhaCungCap.Size = new System.Drawing.Size(763, 235);
			this.dgvNhaCungCap.TabIndex = 9;
			this.dgvNhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellContentClick);
			this.dgvNhaCungCap.Click += new System.EventHandler(this.dgvNhaCungCap_Click);
			// 
			// btnSkip
			// 
			this.btnSkip.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_skippng1;
			this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSkip.Location = new System.Drawing.Point(409, 12);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(86, 35);
			this.btnSkip.TabIndex = 4;
			this.btnSkip.Text = "Bỏ qua";
			this.btnSkip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSkip.UseVisualStyleBackColor = true;
			this.btnSkip.Click += new System.EventHandler(this.btnBoQua_Click);
			// 
			// btnExit
			// 
			this.btnExit.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_exit_png2;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(682, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(79, 35);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Đóng";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_savepng1;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(549, 12);
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
			this.btnEdit.Image = global::QuanLyBanHang.Properties.Resources.Safeimagekit_editpng1;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(143, 12);
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
			this.btnDelete.Image = global::QuanLyBanHang.Properties.Resources.icons8_delete_32;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(276, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(79, 35);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::QuanLyBanHang.Properties.Resources.add__1_;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(2, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(87, 35);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// frmNCC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.dgvNhaCungCap);
			this.Controls.Add(this.txtTenNhaCC);
			this.Controls.Add(this.txtMaNhaCC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 550);
			this.MinimumSize = new System.Drawing.Size(0, 486);
			this.Name = "frmNCC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhà cung cấp";
			this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.TextBox txtMaNhaCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.Button btnSkip;
    }
}