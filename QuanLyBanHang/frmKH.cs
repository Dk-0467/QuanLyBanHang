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
    public partial class frmKH : Form
    {
        DataTable dtKH;

        public frmKH()
        {
            InitializeComponent();
            radioBtnNam.Checked = true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false; ;
            btnSkip.Enabled = false; ;
			txtMaKH.Enabled = false; ;
			LoadDataGridView();
        }

		private void btnThem_Click(object sender, EventArgs e)
		{
			btnAdd.Enabled = false;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			btnSkip.Enabled = true;
			btnSave.Enabled = true;
			ResetValues();
			txtMaKH.Enabled = true;
			txtMaKH.Focus();
		}

		public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM KhachHang";
            dtKH = Connecctions.GetDataToTable(sql);
            dgvKhachHang.DataSource = dtKH;
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[4].HeaderText = "Điện thoại";

            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (dtKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();

            if (dgvKhachHang.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim() == "Nam")
                radioBtnNam.Checked = true;
            else radioBtnNu.Checked = true;

            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }
		private void btnXoa_Click(object sender, EventArgs e)
		{
			string sql;
			if (dtKH.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtMaKH.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn Khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (MessageBox.Show("Bạn có muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sql = "DELETE KhachHang WHERE MaKH=N'" + txtMaKH.Text + "'";
				Connecctions.RunSqlDel(sql);
				LoadDataGridView();
				ResetValues();
			}
		}


		private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
			radioBtnNu.Checked = false;
			radioBtnNu.Checked = false;
		}


        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;

            if (dtKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
			if (txtTenKH.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTenKH.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSDT.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length != 10 || !Char.IsDigit(txtSDT.Text, txtSDT.Text.Length - 1))
			{
				MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSDT.Focus();
				return;
			}
			if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (radioBtnNam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";

            sql = "UPDATE KhachHang SET TenKH = N'" + txtTenKH.Text.Trim() + "', GioiTinh = N'" + gt + "', DiaChi = N'" + txtDiaChi.Text.Trim() + "', SDT = N'" + txtSDT.Text.Trim() + "' WHERE MaKH = N'" + txtMaKH.Text.Trim() + "'";
            Connecctions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xác nhận đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql, gt;
			if (txtMaKH.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaKH.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length != 10 || !Char.IsDigit(txtSDT.Text, txtSDT.Text.Length - 1))
			{
				MessageBox.Show("Số điện thoại của bạn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSDT.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			if (txtTenKH.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTenKH.Focus();
				return;
			}
			if (radioBtnNam.Checked == true)
				gt = "Nam";
			else gt = "Nữ";

			sql = "SELECT MaKH FROM KhachHang WHERE MaKH=N'" + txtMaKH.Text.Trim() + "'";
			if (Connecctions.CheckKey(sql))
			{
				MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaKH.Focus();
				txtMaKH.Text = "";
				return;
			}

			sql = "INSERT INTO KhachHang VALUES (N'" + txtMaKH.Text.Trim() + "', N'" + txtTenKH.Text.Trim() + "', N'" + gt + "', N'" + txtDiaChi.Text.Trim() + "', N'" + txtSDT.Text.Trim() + "')";
			Class.Connecctions.RunSQL(sql);
			LoadDataGridView();
			ResetValues();
			btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
			txtMaKH.Enabled = false;
		}

		private void txtSDT_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtMaKH_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtTenKH_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtDiaChi_TextChanged(object sender, EventArgs e)
		{

		}
}
	}
