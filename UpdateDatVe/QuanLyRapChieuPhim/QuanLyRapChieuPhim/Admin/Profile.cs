using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyRapChieuPhim.Admin
{
    public partial class Profile : Form
    {
		string EmployeeID;
		DataProvider dataProvider = new DataProvider();
		public Profile()
        {
            InitializeComponent();
			init();
        }
		private void notification_txtEmpty_Edit()
		{
			TextBox[] textBoxes = { txt_Fullname, txt_Phonenumber, txt_Address, txt_Salary, txt_Password };
			foreach (TextBox tb in textBoxes)
			{
				if (string.IsNullOrWhiteSpace(tb.Text))
				{
					if (tb.Name == "txt_Fullname")
					{
						labelFullname.Text = "Vui lòng nhập tên";
						labelFullname.ForeColor = Color.Red;
						labelFullname.Visible = true;
					}
					if (tb.Name == "txt_Phonenumber")
					{
						labelPhonenumber.Text = "Vui lòng nhập số điện thoại";
						labelPhonenumber.ForeColor = Color.Red;
						labelPhonenumber.Visible = true;
					}
					if (tb.Name == "txt_Address")
					{
						labelPhonenumber.Text = "Vui lòng nhập địa chỉ của bạn";
						labelPhonenumber.ForeColor = Color.Red;
						labelPhonenumber.Visible = true;
					}
					if (tb.Name == "txt_Salary")
					{
						labelSalary.Text = "Vui lòng nhập lương";
						labelSalary.ForeColor = Color.Red;
						labelSalary.Visible = true;
					}

					if (tb.Name == "txt_Password")
					{
						labelPassword.Text = "Vui lòng nhập mật khẩu";
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
					if (tb.Name == "txt_Password")
					{
						labelPassword.Visible = false;
					}
				}
			}
		}
		private void Invisible()
		{
			labelFullname.Visible = false;
			labelPhonenumber.Visible = false;
			labelAddress.Visible = false;
			labelSalary.Visible = false;
			labelUsername.Visible = false;
			labelPassword.Visible = false;		
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
		private void update_employee()
		{
			try
			{
				StringBuilder query_1 = new StringBuilder("EXEC proc_UpdateNhanVien");
				query_1.Append(" @MaCV, @TenNhanVien, @SoDienThoai, @DiaChi, @GioiTinh, @Luong, @TaiKhoanNV, @PassWordNV");

				string gender = getGender();

				Dictionary<string, object> parameters_1 = new Dictionary<string, object>()
				{
					{"@MaCV", cbo_Position.SelectedValue},
					{"@TenNhanVien", txt_Fullname.Text},
					{"@SoDienThoai", txt_Phonenumber.Text },
					{"@DiaChi", txt_Address.Text },
					{"@GioiTinh", gender},
					{"@Luong", txt_Salary.Text},
					{"@TaiKhoanNV", labelUsername.Text},
					{"@PassWordNV", txt_Password.Text}
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
		private void btn_Update_Click(object sender, EventArgs e)
        {
			notification_txtEmpty_Edit();
			TextBox[] textBoxes = { txt_Fullname, txt_Phonenumber, txt_Address, txt_Salary, txt_Password };

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

		private void init()
		{
			load_cbo_Position();
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
		}
		public void ReceiveMessage(string employeeID = "")
		{
			EmployeeID = employeeID;
			cbo_Position.SelectedValue = dataProvider.ExecScalar("select MaCV from NhanVien where MANV = '" + employeeID + "'");
			txt_Fullname.Text = dataProvider.ExecScalar("select TENNV from NhanVien where MANV = '" + employeeID + "'").ToString();
			txt_Phonenumber.Text = dataProvider.ExecScalar("select SODT from NhanVien where MANV = '" + employeeID + "'").ToString();
			txt_Address.Text = dataProvider.ExecScalar("select DiaChi from NhanVien where MANV = '" + employeeID + "'").ToString();
			txt_Salary.Text = dataProvider.ExecScalar("select Luong from NhanVien where MANV = '" + employeeID + "'").ToString();
			txt_Password.Text = dataProvider.ExecScalar("select MATKHAU from TAIKHOAN where MANV = '" + employeeID + "'").ToString();

			string gender = dataProvider.ExecScalar("select GioiTinh from NhanVien where MANV = '" + employeeID + "'").ToString();
			if (gender.Trim() == "Male")
			{
				rdo_Male.Checked = true;
			}
			else if (gender.Trim() == "Other")
			{
				rdo_Other.Checked = true;
			}
			else
			{
				rdo_Female.Checked = true;
			}

			labelUsername.Text = dataProvider.ExecScalar("select TenDN from TAIKHOAN where MANV = '" + employeeID + "'").ToString(); ;

		
		}

		private void ShowHide_Click(object sender, EventArgs e)
		{
			if (txt_Password.PasswordChar == '*')
			{
				txt_Password.PasswordChar = '\0';
				ShowHide.Image = Properties.Resources.eye;
			}
			else
			{
				txt_Password.PasswordChar = '*';
				ShowHide.Image = Properties.Resources.eyebrow;
			}
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			ReceiveMessage(EmployeeID);
		}
	}
}
