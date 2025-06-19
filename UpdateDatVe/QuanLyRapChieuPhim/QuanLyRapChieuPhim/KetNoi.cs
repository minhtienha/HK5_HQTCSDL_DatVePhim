using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim
{
    internal class KetNoi
    {
        public SqlConnection connect;

        public KetNoi()
        {
            connect = new SqlConnection("Data Source=.;Initial Catalog=QuanLy_RapChieuPhim1;Integrated Security=True");

        }

        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
