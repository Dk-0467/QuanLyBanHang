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
    public partial class ReportHD : Form
    {
        public ReportHD()
        {
            InitializeComponent();
        }

        private void ReportHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThueHangHoaDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.quanLyHangHoaDataSet.HoaDon);

            this.reportViewer1.RefreshReport();
        }

    }
}
