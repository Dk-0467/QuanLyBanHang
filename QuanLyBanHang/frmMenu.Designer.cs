namespace QuanLyBanHang
{
    partial class frmMenu
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

     
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhàCungCápToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.helpToolStripMenuItem,
            this.reportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(736, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuHeThong
			// 
			this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
			this.mnuHeThong.Name = "mnuHeThong";
			this.mnuHeThong.Size = new System.Drawing.Size(74, 21);
			this.mnuHeThong.Text = "&Hệ thống";
			// 
			// mnuDangXuat
			// 
			this.mnuDangXuat.Name = "mnuDangXuat";
			this.mnuDangXuat.Size = new System.Drawing.Size(135, 22);
			this.mnuDangXuat.Text = "&Đăng xuất";
			this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
			// 
			// mnuThoat
			// 
			this.mnuThoat.Name = "mnuThoat";
			this.mnuThoat.Size = new System.Drawing.Size(135, 22);
			this.mnuThoat.Text = "&Thoát";
			this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
			// 
			// mnuDanhMuc
			// 
			this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhaCungCap,
            this.mnuKhachHang,
            this.mnuNhanVien,
            this.mnuSanPham});
			this.mnuDanhMuc.Name = "mnuDanhMuc";
			this.mnuDanhMuc.Size = new System.Drawing.Size(78, 21);
			this.mnuDanhMuc.Text = "&Danh mục";
			// 
			// mnuNhaCungCap
			// 
			this.mnuNhaCungCap.Name = "mnuNhaCungCap";
			this.mnuNhaCungCap.Size = new System.Drawing.Size(157, 22);
			this.mnuNhaCungCap.Text = "&Nhà cung cấp";
			this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
			// 
			// mnuKhachHang
			// 
			this.mnuKhachHang.Name = "mnuKhachHang";
			this.mnuKhachHang.Size = new System.Drawing.Size(157, 22);
			this.mnuKhachHang.Text = "&Khách hàng";
			this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
			// 
			// mnuNhanVien
			// 
			this.mnuNhanVien.Name = "mnuNhanVien";
			this.mnuNhanVien.Size = new System.Drawing.Size(157, 22);
			this.mnuNhanVien.Text = "&Nhân viên";
			this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
			// 
			// mnuSanPham
			// 
			this.mnuSanPham.Name = "mnuSanPham";
			this.mnuSanPham.Size = new System.Drawing.Size(157, 22);
			this.mnuSanPham.Text = "&Sản phẩm";
			this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
			// 
			// mnuHoaDon
			// 
			this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
			this.mnuHoaDon.Name = "mnuHoaDon";
			this.mnuHoaDon.Size = new System.Drawing.Size(71, 21);
			this.mnuHoaDon.Text = "&Hóa đơn";
			// 
			// mnuHoaDonBan
			// 
			this.mnuHoaDonBan.Name = "mnuHoaDonBan";
			this.mnuHoaDonBan.Size = new System.Drawing.Size(153, 22);
			this.mnuHoaDonBan.Text = "&Hóa đơn bán";
			this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.helpToolStripMenuItem.Text = "&Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// reportToolStripMenuItem
			// 
			this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.nhàCungCápToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem});
			this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
			this.reportToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
			this.reportToolStripMenuItem.Text = "&Report";
			// 
			// hóaĐơnToolStripMenuItem
			// 
			this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
			this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.hóaĐơnToolStripMenuItem.Text = "&Hóa đơn";
			this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
			// 
			// kháchHàngToolStripMenuItem
			// 
			this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
			this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.kháchHàngToolStripMenuItem.Text = "&Khách hàng";
			this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
			// 
			// nhânViênToolStripMenuItem
			// 
			this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
			this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.nhânViênToolStripMenuItem.Text = "&Nhân viên";
			this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
			// 
			// nhàCungCápToolStripMenuItem
			// 
			this.nhàCungCápToolStripMenuItem.Name = "nhàCungCápToolStripMenuItem";
			this.nhàCungCápToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.nhàCungCápToolStripMenuItem.Text = "&Nhà cung cấp";
			this.nhàCungCápToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCápToolStripMenuItem_Click);
			// 
			// sảnPhẩmToolStripMenuItem
			// 
			this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
			this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.sảnPhẩmToolStripMenuItem.Text = "&Sản phẩm";
			this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(191, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quản lý bán hàng";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
			this.label2.Location = new System.Drawing.Point(257, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 45);
			this.label2.TabIndex = 2;
			this.label2.Text = "Phần mềm";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.back;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(736, 448);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(752, 487);
			this.MinimumSize = new System.Drawing.Size(752, 487);
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý bán hàng";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhàCungCápToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
		private System.Windows.Forms.Label label2;
	}
}