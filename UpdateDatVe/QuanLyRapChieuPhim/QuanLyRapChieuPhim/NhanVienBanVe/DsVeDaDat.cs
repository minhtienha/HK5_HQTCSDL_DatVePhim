using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.NhanVienBanVe
{
    public partial class DsVeDaDat : Form
    {
        public DsVeDaDat()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        private void DsVeDaDat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ngaychieu = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string query = "EXEC proc_DsVeDaDat '" + ngaychieu + "'";

            DataTable dt = db.getDataTable(query);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Ngày chiếu chưa có vé nào đặt");
                return;
            }
        }
    }
}
