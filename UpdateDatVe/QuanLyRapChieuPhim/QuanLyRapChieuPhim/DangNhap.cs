using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim;
using QuanLyRapChieuPhim.NhanVienBanDoAn;
using QuanLyRapChieuPhim.NhanVienBanVe;
using System.Data.SqlClient;


namespace QuanLyRapChieuPhim
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            invisible();
        }

        DBConnect db;
        public static string currentUserID;

        private void invisible()
        {
            labelNotification.Text = string.Empty;
            labelPassword.Text = string.Empty;
            labelPUsername.Text = string.Empty;
        }
        private void notification_txtEmpty()
        {
            TextBox[] textBoxes = { txtTenDangNhap, txtMatKhau };
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    if (tb.Name == "txtTenDangNhap")
                    {
                        labelPUsername.Text = "Please enter username";
                        labelPUsername.Visible = true;
                    }
                    if (tb.Name == "txtMatKhau")
                    {
                        labelPassword.Text = "Please enter password";
                        labelPassword.Visible = true;
                    }
                }
                else
                {
                    if (tb.Name == "txtTenDangNhap")
                    {
                        labelPUsername.Visible = false;
                    }
                    if (tb.Name == "txtMatKhau")
                    {
                        labelPassword.Visible = false;
                    }
                }
            }
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBConnect.user = tenDN;
            DBConnect.pass = mk;
            DataProvider.user = tenDN;
            DataProvider.pass = mk;

            try
            {
                db = new DBConnect(tenDN, mk);
                db.Open(); // Mở kết nối
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra tên đăng nhập và mật khẩu.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string str_slt = "SELECT MANV FROM NHANVIEN WHERE TENDN = '" + tenDN + "'";

            object kq = db.getScalar(str_slt);
            if (kq != null)
            {
                currentUserID = kq.ToString();
            }

            string checkRole = "EXEC dbo.DangNhap";

            string roleName = db.getScalar(checkRole).ToString();

            if (roleName == "Admin")
            {
                MessageBox.Show("Đăng nhập với vai trò: Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string query_EmpID = " select nv.MANV from NhanVien nv, TAIKHOAN us where nv.MANV = us.MANV and us.TenDN = '" + tenDN + "'";
                string empID = (string)db.getScalar(query_EmpID);
                AdminHome adminForm = new AdminHome(empID);
                adminForm.Show();
                this.Hide();
            }
            else if (roleName == "NhanVien_BanVe")
            {
                MessageBox.Show("Đăng nhập với vai trò: Nhân viên bán vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NvBanVeHome nvBanVeForm = new NvBanVeHome();
                nvBanVeForm.Show();
                this.Hide();
            }
            else if (roleName == "NhanVien_BanDoAn")
            {
                MessageBox.Show("Đăng nhập với vai trò: Nhân viên bán đồ ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatDoAn nvBanDoAnForm = new DatDoAn();
                nvBanDoAnForm.Show();
                this.Hide();
            }
        }

        private void ShowHide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
                ShowHide.Image = Properties.Resources.eye;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                ShowHide.Image = Properties.Resources.eyebrow;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
