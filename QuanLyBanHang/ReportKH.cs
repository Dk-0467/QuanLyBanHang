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
	public partial class ReportKH : Form
	{
		public ReportKH()
		{
			InitializeComponent();
		}

		private void ReportKH_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'quanLyThueHangHoaDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyHangHoaDataSet.KhachHang);
           

            this.reportViewer1.RefreshReport();
        }

     
    }
}
