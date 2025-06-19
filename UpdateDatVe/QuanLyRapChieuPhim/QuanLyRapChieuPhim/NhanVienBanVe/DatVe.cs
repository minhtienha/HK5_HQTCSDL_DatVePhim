using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class DatVe : Form
    {
        public DatVe()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(DBConnect.user, DBConnect.pass);

        string maNhanVien = DangNhap.currentUserID;

        private void DatVe_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = null;
            txtNgayLap.Text = null;
            txtThanhTien.Text = "0";
            txtMaNV.Text = null;

            string query = "EXEC proc_HienThiPhim";
            DataTable dt = db.getDataTable(query);
            if (dt.Rows.Count > 0)
            {
                cb_ChonPhim.DataSource = dt;
                cb_ChonPhim.DisplayMember = "TENPHIM";
                cb_ChonPhim.ValueMember = "MAPHIM";
            }
            else
            {
                cb_ChonPhim.DataSource = null;
            }
        }

        private void cb_ChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSuatChieu();
        }

        private void cb_GioChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetGhe();
            UpdateGheNgoi();
        }

        private void UpdateSuatChieu()
        {
            string maPhim = cb_ChonPhim.SelectedValue.ToString();
            string ngayChieu = DateTime.Now.ToString("yyyy-MM-dd");

            string query = "EXEC proc_GetSuatChieu @maPhim = '" + maPhim + "', @ngayChieu = '" + ngayChieu + "'";
            DataTable dt = db.getDataTable(query);
            if(dt.Rows.Count > 0)
            {
                cb_GioChieu.DataSource = dt;
                cb_GioChieu.DisplayMember = "ThoiGian";
                cb_GioChieu.ValueMember = "MASC";
            }
            else
            {
                cb_GioChieu.DataSource = null;
            }
        }

        private void ResetGhe()
        {
            foreach (Control c in tb_GheNgoi.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.Transparent;
                    c.Enabled = true;
                }
            }
        }

        private void UpdateGheNgoi()
        {
            string ngayChieu = DateTime.Now.ToString("yyyy-MM-dd");
            string maPhim = cb_ChonPhim.SelectedValue.ToString();

            if (cb_GioChieu.SelectedValue == null)
            {
                return;
            }

            string masc = cb_GioChieu.SelectedValue.ToString();

            try
            {
                string query = "SELECT * " +
                            "FROM dbo.func_CapNhatGheTrung('" + ngayChieu + "', '" + maPhim + "', '" + masc + "');";

                DataTable dt = db.getDataTable(query);
                foreach (Control c in tb_GheNgoi.Controls)
                {
                    if (c is Button)
                    {
                        int soghe = int.Parse(c.Text.Substring(4));
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["TENGHE"].ToString() == soghe.ToString())
                                {
                                    c.BackColor = Color.Yellow;
                                    c.Enabled = false;
                                }
                            }
                        }
                        else
                        {
                            ResetGhe();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cb_GioChieu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn giờ chiếu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Button> dsGheChon = tb_GheNgoi.Controls.OfType<Button>().ToList();

            if (!dsGheChon.Any(b1 => b1.BackColor == Color.GreenYellow))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngayHienTai = DateTime.Now.ToString("ddMMyyyy");

            string ttHD = "HD";

            string maHD = TaoMaTuDong(ttHD, "HOADON", ngayHienTai);

            txtMaHD.Text = maHD;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtMaNV.Text = maNhanVien;
        }

        private string TaoMaTuDong(string tt, string tenBang, string ngay)
        {
            string kq = null;

            string query = "SELECT dbo.func_SinhMaTuDong('" + tt + "', '" + tenBang + "', '" + ngay + "')";

            try
            {
                kq = db.getScalar(query).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return kq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            decimal giaGhe = 100000;
            if (b.BackColor == Color.GreenYellow)
            {
                txtThanhTien.Text = "" + (int.Parse(txtThanhTien.Text) - giaGhe);
                b.BackColor = Color.Transparent;
            }
            else
            {
                txtThanhTien.Text = "" + (int.Parse(txtThanhTien.Text) + giaGhe);
                b.BackColor = Color.GreenYellow;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Chưa tạo hoá đơn mới");
                return;
            }

            List<Button> dsGheChon = tb_GheNgoi.Controls.OfType<Button>().ToList();

            string manv = txtMaNV.Text;
            DateTime ngayLapDate = DateTime.Parse(txtNgayLap.Text);
            string ngaylap = ngayLapDate.ToString("yyyy-MM-dd");

            string query_hd = "EXEC proc_TaoHD @MAHD = '" + mahd + "', @MANV = '" + manv + "', @NGAYLAP = '" + ngaylap + "'";

            db.getNonQuery(query_hd);

            try
            {
                foreach (var b in dsGheChon)
                {
                    if (b.BackColor == Color.GreenYellow)
                    {
                        b.BackColor = Color.Yellow;

                        decimal giaGhe = 100000;

                        string tenGhe = b.Text.Substring(4);
                        int soGhe = int.Parse(tenGhe);

                        string ttVE = "VE";
                        string ngayHienTai = DateTime.Now.ToString("ddMMyyyy");

                        string mave = TaoMaTuDong(ttVE, "VE", ngayHienTai);

                        string masc = cb_GioChieu.SelectedValue.ToString();

                        string query_ve = "EXEC proc_ThemVe @MAVE = '" + mave +
                                "', @MASUATCHIEU = '" + masc +
                                "', @MAHD = '" + mahd +
                                "', @TENGHE = " + soGhe +
                                ", @GIAGHE = " + giaGhe;

                        db.getNonQuery(query_ve);
                    }
                }
                txtThanhTien.Text = "0";
                txtMaHD.Text = "";
                txtNgayLap.Text = "";
                txtMaNV.Text = "";
                MessageBox.Show("Đặt vé thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt vé: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void DatVe_Load_1(object sender, EventArgs e)
        {
            DatVe_Load(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}