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
    public partial class frmNCC : Form
    {
        DataTable dtNCC; 

        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            txtMaNhaCC.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
        }
		private void btnXoa_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtMaNhaCC.Text == "")
			{
				MessageBox.Show("Bạn hãy chọn Nhà cung cấp nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (dtNCC.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MessageBox.Show("Bạn có muốn xác nhận xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sql = "DELETE NhaCungCap WHERE MaNCC=N'" + txtMaNhaCC.Text + "'";
				Class.Connecctions.RunSqlDel(sql);
				LoadDataGridView();
				txtMaNhaCC.Text = "";
				txtTenNhaCC.Text = "";
			}
		}



		private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
			if (dgvNhaCungCap.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Bạn hiện đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCC.Focus();
                return;
            }
            txtMaNhaCC.Text = dgvNhaCungCap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNhaCC.Text = dgvNhaCungCap.CurrentRow.Cells["TenNCC"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtMaNhaCC.Enabled = true;     
            txtMaNhaCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNhaCC.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn hãy nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCC.Focus();
                return;
            }

            if (txtTenNhaCC.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn hãy nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCC.Focus();
                return;
            }

            sql = "Select MaNCC from NhaCungCap where MaNCC = N'" + txtMaNhaCC.Text.Trim() + "'";
            if (Class.Connecctions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp của bạn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaCC.Focus();
                return ;
            }

            sql = "INSERT INTO NhaCungCap VALUES(N'" + txtMaNhaCC.Text + "', N'"+ txtTenNhaCC.Text +"')";
            Class.Connecctions.RunSQL(sql);
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
            txtMaNhaCC.Enabled = false;
            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            LoadDataGridView();
        }




        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
            txtMaNhaCC.Enabled = false;
			txtMaNhaCC.Text = "";
			txtTenNhaCC.Text = "";
		}
		private void LoadDataGridView()
		{
			string sql;
			sql = "Select * from NhaCungCap";

			dtNCC = Class.Connecctions.GetDataToTable(sql);
			dgvNhaCungCap.DataSource = dtNCC;
			dgvNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
			dgvNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";

			dgvNhaCungCap.AllowUserToAddRows = false;
			dgvNhaCungCap.EditMode = DataGridViewEditMode.EditProgrammatically;
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtMaNhaCC.Text == "")
			{
				MessageBox.Show("Bạn hãy chọn Nhà cung cấp nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtTenNhaCC.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn hãy nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (dtNCC.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			sql = "UPDATE NhaCungCap SET TenNCC=N'" + txtTenNhaCC.Text.ToString() + "' WHERE MaNCC=N'" + txtMaNhaCC.Text + "'";
			Class.Connecctions.RunSQL(sql);
			LoadDataGridView();
			txtMaNhaCC.Text = "";
			txtTenNhaCC.Text = "";

			btnSkip.Enabled = false;
		}
		private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Xác nhận đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

		private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
