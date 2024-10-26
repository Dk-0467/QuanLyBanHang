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
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Class.Connecctions.Connect();  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xác nhận thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class.Connecctions.Disconnect();   
                Application.Exit();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            sql = "Select count(*) from TaiKhoan where TenDangNhap = '"+ txtUser.Text.Trim() +"' and MatKhau = '"+ txtPass.Text.Trim() +"'";
            if (Convert.ToInt32(Connecctions.GetFieldValues(sql)) == 1)
            {
                frmMenu main = new frmMenu(this);
                main.Show();
                this.Hide();
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                return;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
