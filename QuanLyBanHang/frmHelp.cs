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
	public partial class frmHelp : Form
	{
		public frmHelp()
		{
			InitializeComponent();
		}

		

		private void frmHelp_Load(object sender, EventArgs e)
		{
			string htmlContent = @"
    <html>
    <head>
        <title>Hướng dẫn sử dụng phần mềm Quản lí Tour</title>
        <style>
            body {
                text-color: #31473A
                font-family: Arial, sans-serif;
                background-color: #EDF4F2;
                margin: 0;
                padding: 0;
            }

            h1, h2 {
                text-align: center;
                margin-top: 30px;
            }

            p {
                margin-bottom: 10px;
            }

            ul {
                margin-left: 15px;
            }

            li {
                margin-bottom: 5px;
            }

            strong {
                font-weight: bold;
            }
        </style>
    </head>
    <body>
        <h1>Hướng dẫn sử dụng phần mềm Quản lý bán hàng</h1>
        
        <h2>Đăng nhập</h2>
        <p>Nhập đúng tài khoản và mật khẩu để truy cập vào phần mềm.</p>
        
        <h2>Giao diện phần mềm</h2>
        <p>Giao diện của phần mềm hiển thị các thông tin và chức năng sau:</p>
        
        <ul>
            <li>
                <strong>Hiển thị dữ liệu bảng:</strong> Phần mềm hiển thị dữ liệu từ CSDL trong một bảng trên giao diện. Bạn có thể xem thông tin chi tiết về nhân viên, khách hàng, các nhà cung cấp, sản phẩm...
            </li>
            <li>
                <strong>Nơi nhập thông tin và chỉnh sửa:</strong> Bạn có thể nhập thông tin và chỉnh sửa các dữ liệu trong các mục tương ứng. Các mục này có thể bao gồm thông tin về danh sách các nhân viên, khách hàng, nhà cung cấp, sản phẩm và cả hóa đơn bán hàng.
            </li>
            <li>
                <strong>Các nút điều khiển:</strong> Phần mềm cung cấp các nút điều khiển để thao tác với dữ liệu. Dưới đây là các nút điều khiển chính:
                <ul>
                    <li><strong>Thêm:</strong> Chọn đối tượng hoặc thao tác bạn muốn thêm.Xác nhận hoặc lưu lại thao tác (thường có nút ""Xác nhận"" hoặc ""Thêm"").</li>
                    <li><strong>Sửa:</strong> Chỉnh sửa thông tin hoặc nội dung cần sửa đổi.Xác nhận hoặc lưu lại sự thay đổi (thường có nút ""Xác nhận"" hoặc ""Lưu"").</li>
                    <li><strong>Xóa:</strong> Xóa dữ liệu đã chọn khỏi CSDL. (Lưu ý: Hãy cân nhắc kỹ trước khi xóa, vì thao tác này có thể không thể đảo ngược.).</li>
                    <li><strong>Bỏ qua:</strong> Thao tác ""Bỏ qua"" thường dùng để bỏ qua hoặc skip một phần của quá trình mà bạn không muốn hoặc không cần tham gia.</li>
                    <li><strong>Lưu:</strong>  Sau khi nhấn ""Lưu,"" thông tin sẽ được cập nhật và lưu lại.</li>
                    <li><strong>Thoát:</strong> Thao tác ""Thoát"" giúp bạn rời khỏi trang hoặc ứng dụng mà bạn đang sử dụng.</li>
                </ul>
            </li>
            <li>
                <strong>Tab chuyển nhanh:</strong> Phần mềm cung cấp các Tab chuyển nhanh giúp bạn dễ dàng quản lý và duyệt giữa nhiều form hoặc nhiều nhiệm vụ trong phầm mềm mà bạn đang sử dụng.
            </li>
            <li>
                <strong>Thông tin:</strong> Bạn có thể xem các thông tin như phiên bản phần mềm, bản quyền và các thông tin khác liên quan.
            </li>
        </ul>

    </body>
    </html>
";

			webBrowser1.DocumentText = htmlContent;
		}

	}
}
