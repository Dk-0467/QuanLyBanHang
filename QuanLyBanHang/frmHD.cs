using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmHD : Form
    {
        DataTable dtHD;

        public frmHD()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            txtMaHD.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtGiamgia.Text = "0";
            txtTong.ReadOnly = true;

            // Nạp ComboBox cho hóa đơn
            Connecctions.FillComboBox("SELECT MaHD FROM HoaDon", cboMaHoaDon, "MaHD");
            cboMaHoaDon.SelectedIndex = -1; // Đặt giá trị mặc định cho ComboBox

            // Nạp ComboBox cho khách hàng và nhân viên
            Connecctions.FillComboBox("SELECT MaKH, TenKH FROM KhachHang", cboMaKH, "MaKH");
            cboMaKH.SelectedIndex = -1;
            Connecctions.FillComboBox("SELECT MaNV, TenNV FROM NhanVien", cboMaNV, "MaNV");
            cboMaNV.SelectedIndex = -1;
            Connecctions.FillComboBox("SELECT MaSP, TenSP FROM SanPham", cboMaSP, "MaSP");
            cboMaSP.SelectedIndex = -1;

            // Nạp dữ liệu vào DataGridView
            LoadDataGridView();
        }
        private void btnThem_Click(object sender, EventArgs e)
		{
			btnAdd.Enabled = false;
			btnDelete.Enabled = false;
			btnSave.Enabled = true;
			ResetValues();
			txtMaHD.Text = Connecctions.CreateKey("HD");
			LoadDataGridView();
		}

		private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM HoaDon WHERE MaHD = N'" + txtMaHD.Text + "'";
            dtpNgayBan.Value = DateTime.Parse(Connecctions.GetFieldValues(str));

            str = "SELECT MaNV FROM HoaDon WHERE MaHD = N'" + txtMaHD.Text + "'";
            cboMaNV.Text = Connecctions.GetFieldValues(str);

            str = "SELECT MaKH FROM HoaDon WHERE MaHD = N'" + txtMaHD.Text + "'";
            cboMaKH.Text = Connecctions.GetFieldValues(str);

            str = "SELECT TongTien FROM HoaDon WHERE MaHD = N'" + txtMaHD.Text + "'";
            txtTong.Text = Connecctions.GetFieldValues(str);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                // Lấy mã hóa đơn từ dòng hiện tại trong DataGridView
                string maHDXoa = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();

                // Xóa các dòng chi tiết hóa đơn dựa trên mã hóa đơn đã chọn
                sql = "SELECT * FROM ChiTietHoaDon WHERE MaHD = N'" + maHDXoa + "'";
                DataTable dtRows = Connecctions.GetDataToTable(sql);

                for (int row = 0; row < dtRows.Rows.Count; row++)
                {
                    sql = "DELETE FROM ChiTietHoaDon WHERE MaHD = N'" + maHDXoa + "' AND MaSP = N'" + dtRows.Rows[row]["MaSP"] + "'";
                    Connecctions.RunSqlDel(sql);
                }

                // Xóa hóa đơn từ bảng HoaDon
                sql = "DELETE FROM HoaDon WHERE MaHD = N'" + maHDXoa + "'";
                Connecctions.RunSqlDel(sql);

                // Đặt lại các giá trị và cập nhật DataGridView
                ResetValues();
                LoadDataGridView();
                btnDelete.Enabled = false;
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, tong;

            // Kiểm tra xem mã hóa đơn đã tồn tại chưa
            sql = "SELECT MaHD FROM HoaDon WHERE MaHD=N'" + txtMaHD.Text.Trim() + "'";
            if (!Connecctions.CheckKey(sql))
            {
                // Kiểm tra mã nhân viên
                if (cboMaNV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn hãy nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                // Kiểm tra mã khách hàng
                if (cboMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn hãy nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKH.Focus();
                    return;
                }
                // Thêm mới hóa đơn
                sql = "INSERT INTO HoaDon (MaHD, MaNV, MaKH, NgayBan, TongTien) VALUES (N'" + txtMaHD.Text.Trim() + "', N'" + cboMaNV.SelectedValue + "', N'" + cboMaKH.SelectedValue + "', '" + dtpNgayBan.Value.ToString("yyyy/MM/dd") + "', 0)";
                Connecctions.RunSQL(sql);
            }

            // Kiểm tra mã sản phẩm
            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSP.Focus();
                return;
            }

            // Kiểm tra số lượng
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn hãy nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong chi tiết hóa đơn chưa
            sql = "SELECT MaSP FROM ChiTietHoaDon WHERE MaSP=N'" + cboMaSP.SelectedValue + "' AND MaHD = N'" + txtMaHD.Text.Trim() + "'";
            if (Connecctions.CheckKey(sql))
            {
                MessageBox.Show("Sản phẩm này đã có rồi, mời bạn chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaSP.Focus();
                return;
            }

            // Kiểm tra số lượng tồn kho của sản phẩm
            sl = Convert.ToDouble(Connecctions.GetFieldValues("SELECT SoLuong FROM SanPham WHERE MaSP = N'" + cboMaSP.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text.Trim()) > sl)
            {
                MessageBox.Show("Số lượng sản phẩm này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

            // Tính thành tiền với giảm giá
            double soLuong = Convert.ToDouble(txtSoLuong.Text.Trim());
            double donGia = Convert.ToDouble(txtDonGia.Text.Trim());
            double giamGia = Convert.ToDouble(txtGiamgia.Text.Trim());
            double thanhTien = soLuong * donGia * (1 - giamGia / 100);

            // Thêm chi tiết hóa đơn
            sql = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia, GiamGia, ThanhTien) VALUES (N'" + txtMaHD.Text.Trim() + "', N'" + cboMaSP.SelectedValue + "', " + soLuong + ", " + donGia + ", " + giamGia + ", " + thanhTien + ")";
            Connecctions.RunSQL(sql);
            LoadDataGridView();

            // Tính lại tổng tiền cho hóa đơn
            tong = Convert.ToDouble(Connecctions.GetFieldValues("SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE MaHD = N'" + txtMaHD.Text.Trim() + "'"));
            sql = "UPDATE HoaDon SET TongTien = " + tong + " WHERE MaHD = N'" + txtMaHD.Text.Trim() + "'";
            Connecctions.RunSQL(sql);

            txtTong.Text = tong.ToString("N2");
            ResetValuesHang();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM HoaDon";
            dtHD = Connecctions.GetDataToTable(sql);
            dgvHoaDon.DataSource = dtHD;

            dgvHoaDon.Columns[0].HeaderText = "Mã HD";
            dgvHoaDon.Columns[1].HeaderText = "Mã NV";
            dgvHoaDon.Columns[2].HeaderText = "Mã KH";
            dgvHoaDon.Columns[3].HeaderText = "Ngày Bán";
            dgvHoaDon.Columns[4].HeaderText = "Tổng tiền";

            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
		{
			txtMaHD.Text = "";
			cboMaKH.Text = "";
			cboMaNV.Text = "";
			cboMaSP.Text = "";
			txtTong.Text = "0";
			txtSoLuong.Text = "";
			txtThanhTien.Text = "0";
			dtpNgayBan.Text = DateTime.Now.ToShortDateString();
		}

		private void ResetValuesHang()
        {
            cboMaSP.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            string MaSPxoa, sql;
            double tong;

            if (dtHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((MessageBox.Show("Bạn có muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                MaSPxoa = dgvHoaDon.CurrentRow.Cells["MaSP"].Value.ToString(); // Lấy mã sản phẩm của dòng cần xóa

                // Xóa chi tiết hóa đơn của sản phẩm đã chọn
                sql = "DELETE FROM ChiTietHoaDon WHERE MaHD = N'" + txtMaHD.Text + "' AND MaSP = N'" + MaSPxoa + "'";
                Connecctions.RunSQL(sql);

                // Tính lại tổng tiền từ bảng ChiTietHoaDon sau khi xóa
                tong = Convert.ToDouble(Connecctions.GetFieldValues("SELECT ISNULL(SUM(ThanhTien), 0) FROM ChiTietHoaDon WHERE MaHD = N'" + txtMaHD.Text + "'"));

                // Cập nhật lại tổng tiền trong bảng HoaDon
                sql = "UPDATE HoaDon SET TongTien = " + tong + " WHERE MaHD = N'" + txtMaHD.Text + "'";
                Connecctions.RunSQL(sql);

                // Hiển thị lại tổng tiền trên giao diện
                txtTong.Text = tong.ToString("N2");

                // Cập nhật lại DataGridView
                LoadDataGridView();
            }
        }

        private void cboMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            sql = "Select TenNV from NhanVien where MaNV = N'" + cboMaNV.SelectedValue + "'";
            txtTenNV.Text = Connecctions.GetFieldValues(sql);
        }

        private void cboMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
            sql = "Select TenKH from KhachHang where MaKH = N'" + cboMaKH.SelectedValue + "'";
            txtTenKH.Text = Connecctions.GetFieldValues(sql);
            sql = "Select DiaChi from KhachHang where MaKH = N'" + cboMaKH.SelectedValue + "'";
            txtDiaChi.Text = Connecctions.GetFieldValues(sql);
            sql = "Select SDT from KhachHang where MaKH= N'" + cboMaKH.SelectedValue + "'";
            txtSDT.Text = Connecctions.GetFieldValues(sql);
        }
                private void cboMaHoaDon_DropDown(object sender, EventArgs e)
        {
            Connecctions.FillComboBox("SELECT MaHD FROM HoaDon", cboMaHoaDon, "MaHD");
            cboMaHoaDon.SelectedIndex = -1;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xác nhận đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboMaSanPham_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtDonGia.Text = "";
            }
            sql = "SELECT TenSP FROM SanPham WHERE MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtTenSP.Text = Connecctions.GetFieldValues(sql);
            sql = "SELECT DonGiaBan FROM SanPham WHERE MaSP =N'" + cboMaSP.SelectedValue + "'";
            txtDonGia.Text = Connecctions.GetFieldValues(sql);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;

            // Kiểm tra số lượng
            sl = string.IsNullOrEmpty(txtSoLuong.Text) ? 0 : Convert.ToDouble(txtSoLuong.Text);

            // Kiểm tra đơn giá
            dg = string.IsNullOrEmpty(txtDonGia.Text) ? 0 : Convert.ToDouble(txtDonGia.Text);

            // Kiểm tra giảm giá
            gg = string.IsNullOrEmpty(txtGiamgia.Text) ? 0 : Convert.ToDouble(txtGiamgia.Text);

            // Tính toán thành tiền với giảm giá
            tt = sl * dg * (1 - gg / 100);

            // Cập nhật giá trị vào các ô hiển thị
            txtThanhTien.Text = tt.ToString("N2");
            txtTong.Text = tt.ToString("N2");
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã hóa đơn để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql;
            sql = "SELECT MaHD FROM HoaDon WHERE MaHD=N'" + cboMaHoaDon.SelectedValue + "'";
            if (Connecctions.CheckKey(sql)) // Kiểm tra xem hóa đơn có tồn tại không
            {
                txtMaHD.Text = cboMaHoaDon.SelectedValue.ToString();
                LoadInfoHoaDon();  // Nạp thông tin của hóa đơn
                LoadDataGridView(); // Nạp chi tiết các sản phẩm trong hóa đơn

                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn với mã này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValues();
            }
        }




        private void label16_Click(object sender, EventArgs e)
		{

		}

		private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtThanhTien_TextChanged(object sender, EventArgs e)
		{

		}



		private void button1_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel Files|*.xls";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				xuatReport(dgvHoaDon, saveFileDialog.FileName);
			}
		}
		private void xuatReport(DataGridView dataGridView, string filePath)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
				{
					for (int i = 0; i < dataGridView.Columns.Count; i++)
					{
						sw.Write(dataGridView.Columns[i].HeaderText);
						if (i < dataGridView.Columns.Count - 1)
							sw.Write(",");
					}
					sw.WriteLine();
					foreach (DataGridViewRow row in dataGridView.Rows)
					{
						for (int i = 0; i < dataGridView.Columns.Count; i++)
						{
							sw.Write(row.Cells[i].Value);
							if (i < dataGridView.Columns.Count - 1)
								sw.Write(",");
						}
						sw.WriteLine();
					}
				}
				MessageBox.Show("Đã xuất ra File.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Báo Lỗi: " + ex.Message);
			}
		}

		private void txtTong_TextChanged(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
