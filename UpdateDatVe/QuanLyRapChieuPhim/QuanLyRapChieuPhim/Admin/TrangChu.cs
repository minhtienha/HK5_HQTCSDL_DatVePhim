using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.Admin
{
    public partial class TrangChu : Form
    {
		DataProvider dataProvider = new DataProvider();
		public TrangChu()
        {
            InitializeComponent();
			init();
        }
		private void init()
		{
			load();
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			load();
		}

		private void load()
        {
            object staffCount = dataProvider.ExecScalar("SELECT COUNT(*) FROM NhanVien WHERE MaCV = 2 OR MaCV = 3");
            object adminCount = dataProvider.ExecScalar("SELECT COUNT(*) FROM NhanVien WHERE MaCV = 1");
            object customerCount = dataProvider.ExecScalar("SELECT COUNT(*) FROM KhachHang");

            labelStaff.Text = staffCount.ToString();
            labelAdmin.Text = adminCount.ToString();
            labelCus.Text = customerCount.ToString();
        }
	}
}
