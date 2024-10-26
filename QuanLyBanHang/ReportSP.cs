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
	public partial class ReportSP : Form
	{
		public ReportSP()
		{
			InitializeComponent();
		}

		private void ReportSP_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'quanLyThueHangHoaDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.quanLyHangHoaDataSet.SanPham);

            this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
