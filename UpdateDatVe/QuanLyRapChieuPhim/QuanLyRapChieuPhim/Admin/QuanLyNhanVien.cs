using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class QuanLyNhanVien : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection con;
        SqlDataAdapter adapter1;
        SqlCommandBuilder cmdb;
        DataTable dt;
        DataTable dt1;
        DataProvider dataProvider = new DataProvider();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            con = kn.connect;
            init();
        }
        private void init()
        {
            rdo_Male.Checked = true;
            Invisible();
            load_cbo_Position();
            loaddgridNhanVien();
        }

        //=============================================================================================

        private void notification_txtEmpty()
        {
            TextBox[] textBoxes = { txt_Fullname, txt_Phonenumber, txt_Address, txt_Salary, txt_Username, txt_Password };
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    if (tb.Name == "txt_Fullname")
                    {
                        labelFullname.Text = "Please enter fullname";
                        labelFullname.ForeColor = Color.Red;
                        labelFullname.Visible = true;
                    }
                    if (tb.Name == "txt_Phonenumber")
                    {
                        labelPhonenumber.Text = "Please enter phone number";
                        labelPhonenumber.ForeColor = Color.Red;
                        labelPhonenumber.Visible = true;
                    }
                    if (tb.Name == "txt_Address")
                    {
                        labelAddress.Text = "Please enter address";
                        labelAddress.ForeColor = Color.Red;
                        labelAddress.Visible = true;
                    }
                    if (tb.Name == "txt_Salary")
                    {
                        labelSalary.Text = "Please enter salary";
                        labelSalary.ForeColor = Color.Red;
                        labelSalary.Visible = true;
                    }
                    if (tb.Name == "txt_Username")
                    {
                        labelUsername.Text = "Please enter username";
                        labelUsername.ForeColor = Color.Red;
                        labelUsername.Visible = true;
                    }
                    if (tb.Name == "txt_Password")
                    {
                        labelPassword.Text = "Please enter password";
                        labelPassword.ForeColor = Color.Red;
                        labelPassword.Visible = true;
                    }
                }
                else
                {
                    if (tb.Name == "txt_Fullname")
                    {
                        labelFullname.Visible = false;
                    }
                    if (tb.Name == "txt_Phonenumber")
                    {
                        labelPhonenumber.Visible = false;
                    }
                    if (tb.Name == "txt_Address")
                    {
                        labelAddress.Visible = false;
                    }
                    if (tb.Name == "txt_Salary")
                    {
                        labelSalary.Visible = false;
                    }
                    if (tb.Name == "txt_Username")
                    {
                        labelUsername.Visible = false;
                    }
                    if (tb.Name == "txt_Password")
                    {
                        labelPassword.Visible = false;
                    }
                }
            }
        }
        void loaddgridNhanVien(string search = "")
        {
            string sql = "SELECT * FROM NHANVIEN";
            adapter1 = new SqlDataAdapter(sql, con);
            dt1 = new DataTable();
            adapter1.Fill(dt1);
            dgvNhanVien.DataSource = dt1;

            // Check if there are any rows before accessing the data
            if (dgvNhanVien.Rows.Count > 0)
            {

            }

            if (search == "")
            {
                DataTable dt = new DataTable();
                string query = "EXEC proc_ViewUser";
                dt = dataProvider.ExecQuery(query);

                dgvNhanVien.DataSource = dt;
            }
            else
            {
                StringBuilder query = new StringBuilder("proc_ViewUser_by_search ");
                query.Append(" @search");
                DataTable dt = new DataTable();
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@search", search}
                };
                dt = dataProvider.ExecQuery(query.ToString(), parameters);
                dgvNhanVien.DataSource = dt;
            }
        }

        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && e.RowIndex <= dgvNhanVien.Rows.Count - 1)
                {
                    btn_Xoa.Enabled = true;
                    DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];


                    txt_Fullname_Edit.Text = row.Cells[1].Value.ToString();
                    string chucvu = row.Cells[2].Value.ToString();
                    txt_SDT_Edit.Text = row.Cells[3].Value.ToString();
                    txt_DiaChi_Edit.Text = row.Cells[4].Value.ToString();
                    string gioitinh = row.Cells[5].Value.ToString();
                    txt_Luong_Edit.Text = row.Cells[6].Value.ToString();
                    txt_TenDangNhap_Edit.Text = row.Cells[7].Value.ToString();
                    txt_MatKhau_Edit.Text = row.Cells[8].Value.ToString();

                    if (chucvu == "1")
                    {
                        cboChucVu_Edit.SelectedIndex = 0;
                    }
                    else
                    {
                        cboChucVu_Edit.SelectedIndex = 1;
                    }

                    if (gioitinh == "Nam")
                    {
                        rdoMale_Edit.Checked = true;
                    }
                    else if (gioitinh == "Nữ")
                    {
                        rdoFemale_Edit.Checked = true;
                    }
                    else
                    {
                        rdoOther_Edit.Checked = true;
                    }
                }
                else
                {
                    btn_Xoa.Enabled = false;
                }
            }
        }
        private void load_cbo_Position()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.ExecQuery("Select * from ChucVu");
            cbo_Position.DisplayMember = "TenCV";
            cbo_Position.ValueMember = "MaCV";
            cbo_Position.DataSource = dt;

            cbo_Position.SelectedIndex = 1;

            cbo_Position.DropDownStyle = ComboBoxStyle.DropDownList;

            cboChucVu_Edit.DisplayMember = "TenCV";
            cboChucVu_Edit.ValueMember = "MaCV";
            cboChucVu_Edit.DataSource = dt;

            cboChucVu_Edit.SelectedIndex = 1;

            cboChucVu_Edit.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Invisible()
        {
            labelFullname.Visible = false;
            labelPhonenumber.Visible = false;
            labelAddress.Visible = false;
            labelSalary.Visible = false;
            labelPosition.Visible = false;
            labelNoti.Visible = false;
            labelUsername.Visible = false;
            labelPassword.Visible = false;

            labelFullname_Edit.Visible = false;
            labelSDT_Edit.Visible = false;
            labelAddress_Edit.Visible = false;
            labelLuong_Edit.Visible = false;
            labelPassword_Edit.Visible = false;
            label_ChucVu_Edit.Visible = false;
        }
        private string getGender()
        {
            string gender = "";
            if (rdo_Male.Checked)
            {
                gender = rdo_Male.Text;
            }
            else if (rdo_Female.Checked)
            {
                gender = rdo_Female.Text;
            }
            else
            {
                gender = rdo_Other.Text;
            }
            return gender;
        }    
        private void add_employee_and_user()
        {
            string MaCV = cbo_Position.SelectedValue.ToString();
            string TenNV = txt_Fullname.Text;
            string SDT = txt_Phonenumber.Text;
            string DiaChi = txt_Address.Text;
            string GioiTinh = getGender();
            string Luong = txt_Salary.Text;
            string username = txt_Username.Text;
            string password = txt_Password.Text;


            // Thêm nhân viên và tài khoản người dùng
            StringBuilder query = new StringBuilder("EXEC proc_AddNhanVienAndUser");
            query.Append(" @MaCV, @TenNhanVien, @SoDienThoai, @DiaChi, @GioiTinh, @Luong, @TaiKhoanNV, @PasswordNV ");

            var parameters = new Dictionary<string, object>
            {
                { "@MaCV", MaCV },
                { "@TenNhanVien", TenNV },
                { "@SoDienThoai", SDT },
                { "@DiaChi", DiaChi },
                { "@GioiTinh", GioiTinh },
                { "@Luong", Luong },
                { "@TaiKhoanNV", username },
                { "@PasswordNV", password }
            };

            int result = dataProvider.ExecNonQuery(query.ToString(), parameters);
            if (result > 0)
            {
                labelNoti.Text = "Thêm nhân viên và tạo tài khoản thành công!";
                labelNoti.Visible = true;
            }
            else
            {
                labelNoti.Text = "Có lỗi xảy ra! Vui lòng kiểm tra lại.";
                labelNoti.Visible = true;
            }
        }     
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            notification_txtEmpty();
            TextBox[] textBoxes = { txt_Fullname, txt_Phonenumber, txt_Address, txt_Salary, txt_Username, txt_Password };

            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Focus();
                    return;
                }
            }

            string query = "SELECT count(*) FROM TAIKHOAN WHERE TenDN = '" + txt_Username.Text + "'";

            object result = dataProvider.ExecScalar(query);

            if (int.Parse(result.ToString()) == 0)
            {
                add_employee_and_user();
                loaddgridNhanVien();
            }
            else
            {
                labelNoti.Text = "";
                MessageBox.Show("Tài khoản đã tồn tại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT count(*) FROM TAIKHOAN WHERE TenDN = '" + txt_Username.Text + "'";

            object result = dataProvider.ExecScalar(query);

            if (int.Parse(result.ToString()) == 0)
            {
                pic_valid.Image = Properties.Resources.yes_35px;
            }
            else
            {
                pic_valid.Image = Properties.Resources.no_35px;
            }

            if (txt_Username.Text != "")
            {
                labelUsername.Visible = false;
            }

            if (txt_Username.Text == "")
            {
                pic_valid.Visible = false;
            }
            else
            {
                pic_valid.Visible = true;
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }  
        private void btn_Eye_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '\0')
            {
                txt_Password.PasswordChar = '*';
                btn_Eye.Image = Properties.Resources.eyebrow;
            }
            else
            {
                txt_Password.PasswordChar = '\0';
                btn_Eye.Image = Properties.Resources.eye;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Invisible();
            txt_Fullname.Clear();
            txt_Phonenumber.Clear();
            txt_Address.Clear();
            txt_Salary.Clear();
            load_cbo_Position();
            rdo_Male.Checked = true;
            pic_valid.Visible = false;
            txt_Username.Clear();
            txt_Password.Clear();
        }
        //==============================================================
        private void delete()
        {
            DialogResult r = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
                        {
                            string EmpID = row.Cells[0].Value.ToString();
                            string query_del_acc = "DELETE TAIKHOAN WHERE MANV = '" + EmpID + "'";
                            dataProvider.ExecNonQuery(query_del_acc);

                            string query_del_emp = "DELETE NhanVien WHERE MANV = '" + EmpID + "'";
                            dataProvider.ExecNonQuery(query_del_emp.ToString());
                        }
                        loaddgridNhanVien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void btn_Them_QL_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void txt_MatKhau_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            loaddgridNhanVien();
            txt_Search.Clear();
            btn_Xoa.Enabled = true;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            loaddgridNhanVien(txt_Search.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                 "Xác nhận thoát",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        //======================================================================================

        private void notification_txtEmpty_Edit()
        {
            TextBox[] textBoxes = { txt_Fullname_Edit, txt_SDT_Edit, txt_DiaChi_Edit, txt_Luong_Edit, txt_MatKhau_Edit };
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    if (tb.Name == "txt_Fullname_Edit")
                    {
                        labelFullname_Edit.Text = "Vui lòng nhập tên";
                        labelFullname_Edit.ForeColor = Color.Red;
                        labelFullname_Edit.Visible = true;
                    }
                    if (tb.Name == "txt_SDT_Edit")
                    {
                        labelSDT_Edit.Text = "Vui lòng nhập số điện thoại";
                        labelSDT_Edit.ForeColor = Color.Red;
                        labelSDT_Edit.Visible = true;
                    }
                    if (tb.Name == "txt_DiaChi_Edit")
                    {
                        labelAddress_Edit.Text = "Vui lòng nhập địa chỉ của bạn";
                        labelAddress_Edit.ForeColor = Color.Red;
                        labelAddress_Edit.Visible = true;
                    }
                    if (tb.Name == "txt_Luong_Edit")
                    {
                        labelLuong_Edit.Text = "Vui lòng nhập lương";
                        labelLuong_Edit.ForeColor = Color.Red;
                        labelLuong_Edit.Visible = true;
                    }

                    if (tb.Name == "txt_MatKhau_Edit")
                    {
                        labelPassword_Edit.Text = "Vui lòng nhập mật khẩu";
                        labelPassword_Edit.ForeColor = Color.Red;
                        labelPassword_Edit.Visible = true;
                    }
                }
                else
                {
                    if (tb.Name == "txt_Fullname_Edit")
                    {
                        labelFullname.Visible = false;
                    }
                    if (tb.Name == "txt_SDT_Edit")
                    {
                        labelPhonenumber.Visible = false;
                    }
                    if (tb.Name == "txt_DiaChi_Edit")
                    {
                        labelAddress.Visible = false;
                    }
                    if (tb.Name == "txt_Luong_Edit")
                    {
                        labelSalary.Visible = false;
                    }
                    if (tb.Name == "txt_MatKhau_Edit")
                    {
                        labelPassword.Visible = false;
                    }
                }
            }
        }
        private string getGender_Edit()
        {
            string gender = "";
            if (rdoMale_Edit.Checked)
            {
                gender = rdoMale_Edit.Text;
            }
            else if (rdoFemale_Edit.Checked)
            {
                gender = rdoFemale_Edit.Text;
            }
            else
            {
                gender = rdoOther_Edit.Text;
            }
            return gender;
        }
        private void update_employee()
        {
            try
            {
                StringBuilder query_1 = new StringBuilder("EXEC proc_UpdateNhanVien");
                query_1.Append(" @MaCV, @TenNhanVien, @SoDienThoai, @DiaChi, @GioiTinh, @Luong, @TaiKhoanNV, @PassWordNV");

                string gender = getGender_Edit();

                Dictionary<string, object> parameters_1 = new Dictionary<string, object>()
                {
                    {"@MaCV", cboChucVu_Edit.SelectedValue},
                    {"@TenNhanVien", txt_Fullname_Edit.Text},
                    {"@SoDienThoai", txt_SDT_Edit.Text },                  
                    {"@DiaChi", txt_DiaChi_Edit.Text },                                     
                    {"@GioiTinh", gender},
                    {"@Luong", txt_Luong_Edit.Text},
                    {"@TaiKhoanNV", txt_TenDangNhap_Edit.Text},
                    {"@PassWordNV", txt_MatKhau_Edit.Text}
                };
                int result_1 = dataProvider.ExecNonQuery(query_1.ToString(), parameters_1);


                if (result_1 > 0)
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đã xảy ra: " + ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            notification_txtEmpty_Edit();
            TextBox[] textBoxes = { txt_Fullname_Edit, txt_SDT_Edit, txt_DiaChi_Edit, txt_Luong_Edit, txt_MatKhau_Edit };

            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Focus();
                    return;
                }
            }

            update_employee();
        }

        private void btn_Reset_Edit_Click(object sender, EventArgs e)
        {
            loaddgridNhanVien();
            txt_Search.Clear();
            btn_Xoa.Enabled = false;
            tabControl1.SelectedIndex = 1;
        }

        private void btn_Mat_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau_Edit.PasswordChar == '\0')
            {
                txt_MatKhau_Edit.PasswordChar = '*';
                btn_Mat.Image = Properties.Resources.eyebrow;
            }
            else
            {
                txt_MatKhau_Edit.PasswordChar = '\0';
                btn_Mat.Image = Properties.Resources.eye;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void labelNoti_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
