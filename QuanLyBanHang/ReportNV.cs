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
	public partial class ReportNV : Form
	{
		public ReportNV()
		{
			InitializeComponent();
		}

		private void ReportNV_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'quanLyThueHangHoaDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyHangHoaDataSet.NhanVien);

            this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
