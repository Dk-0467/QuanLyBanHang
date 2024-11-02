using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmNV : Form
    {
        DataTable dtNV;

        public frmNV()
        {
            InitializeComponent();
            radioBtnNam.Checked = true;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
			txtMaNV.Enabled = false; ;
			LoadDataGridView();
        }


        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Bạn hiện đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (dtNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();

            if (dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim() == "Nam") 
                radioBtnNam.Checked = true;
            else radioBtnNu.Checked = true;

            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            radioBtnNu.Checked = false;
            radioBtnNu.Checked = false;
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = "";
            txtSDT.Text = "";
        }
		public void LoadDataGridView()
		{
			string sql;
			sql = "SELECT * FROM NhanVien";
			dtNV = Connecctions.GetDataToTable(sql);
			dgvNhanVien.DataSource = dtNV;
			dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
			dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
			dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
			dgvNhanVien.Columns[3].HeaderText = "Giới tính";
			dgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
			dgvNhanVien.Columns[5].HeaderText = "Điện thoại";

			dgvNhanVien.AllowUserToAddRows = false;
			dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
		}

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            // Kiểm tra độ dài số điện thoại là 11 ký tự
            if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ (chỉ cho phép đúng 10 số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (radioBtnNam.Checked == false && radioBtnNu.Checked == false)
            {
                MessageBox.Show("Bạn hãy chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gt = radioBtnNam.Checked ? "Nam" : "Nữ";
            sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + txtMaNV.Text.Trim() + "'";
            if (Connecctions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên của bạn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }

            // Thực hiện lưu dữ liệu bao gồm số điện thoại đầy đủ
            sql = "INSERT INTO NhanVien VALUES (N'" + txtMaNV.Text.Trim() + "', N'" + txtTenNV.Text.Trim() + "', N'" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") + "', N'" + gt + "', N'" + txtDiaChi.Text.Trim() + "', N'" + txtSDT.Text.Trim() + "')";
            Class.Connecctions.RunSQL(sql);
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtMaNV.Enabled = false;
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn Nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
			if (dtNV.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MessageBox.Show("Bạn muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + txtMaNV.Text + "'";
                Connecctions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
            txtMaNV.Enabled = false;
        }
		private void btnSua_Click(object sender, EventArgs e)
		{
			string sql, gt;

			if (txtMaNV.Text == "")
			{
				MessageBox.Show("Bạn hãy chọn Nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtTenNV.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTenNV.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSDT.Focus();
				return;
			}
			if (dtNV.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtDiaChi.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtDiaChi.Focus();
				return;
			}
            if (txtSDT.Text.Trim().Length != 10 || !txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ (chỉ cho phép đúng 10 số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (radioBtnNam.Checked == true)
				gt = "Nam";
			else gt = "Nữ";

			sql = "UPDATE NhanVien SET TenNV = N'" + txtTenNV.Text.Trim() + "', NgaySinh = N'" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") + "', GioiTinh = N'" + gt + "', DiaChi = N'" + txtDiaChi.Text.Trim() + "', SDT = N'" + txtSDT.Text.Trim() + "' WHERE MaNV = N'" + txtMaNV.Text.Trim() + "'";
			Connecctions.RunSQL(sql);
			LoadDataGridView();
			ResetValues();
			btnSkip.Enabled = false;
		}


		private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xác nhận đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ ô tìm kiếm (có thể là txtTenNhaCC hoặc một TextBox khác mà bạn đã tạo ra cho tìm kiếm)
            string TenNV = txtTenNV.Text.Trim();

            // Kiểm tra xem ô tìm kiếm có trống hay không
            if (string.IsNullOrEmpty(TenNV))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi phương thức tìm kiếm
            SearchNhaCungCap(TenNV);
        }

        private void SearchNhaCungCap(string TenNV)
        {
            // Tạo câu lệnh SQL để tìm kiếm nhà cung cấp theo tên
            string sql = "SELECT * FROM NhanVien WHERE TenNV LIKE N'%" + TenNV + "%'";

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable dtSearch = Connecctions.GetDataToTable(sql);

            // Cập nhật DataGridView với dữ liệu tìm kiếm
            if (dtSearch.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = dtSearch; // Cập nhật DataGridView với kết quả tìm kiếm
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView(); // Nếu không tìm thấy, tải lại toàn bộ dữ liệu
            }

            // Cập nhật tiêu đề cột
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[5].HeaderText = "Điện thoại";

            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void label5_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
