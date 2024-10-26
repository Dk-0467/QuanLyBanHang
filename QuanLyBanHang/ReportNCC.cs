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
	public partial class ReportNCC : Form
	{
		public ReportNCC()
		{
			InitializeComponent();
		}

		private void ReportNCC_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'quanLyThueHangHoaDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyHangHoaDataSet.NhaCungCap);

            this.reportViewer1.RefreshReport();
        }
    }
}
