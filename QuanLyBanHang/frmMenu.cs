using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMenu : Form
    {
        frmDN dangNhap = new frmDN();
        public frmMenu(frmDN dangNhap)
        {
            InitializeComponent();
            this.dangNhap = dangNhap;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNCC ncc = new frmNCC();
            ncc.Show();
        }
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKH kh = new frmKH();
            kh.Show();
        }
        
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNV nv = new frmNV();
            nv.Show();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dangNhap.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHD hd = new frmHD();
            hd.Show();
        }
        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSP sp = new frmSP();
            sp.Show();
        }
		private void mnuThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn xác nhận thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Class.Connecctions.Disconnect();
				Application.Exit();
			}
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmHelp help = new frmHelp();
            help.Show();
		}

		private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ReportHD hd = new ReportHD();
            hd.Show();
		}

		private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ReportKH kh = new ReportKH();   
            kh.Show();
		}

		private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ReportNV nv = new ReportNV();
            nv.Show();
		}

		private void nhàCungCápToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ReportNCC ncc = new ReportNCC();
            ncc.Show();
		}

		private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ReportSP sp = new ReportSP();
            sp.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
