using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyRapChieuPhim
{
    internal class DataProvider
    {
        public static string user { get; set; }
        public static string pass { get; set; }

        public string ConnectionString = "Data Source=.;Initial Catalog=QuanLy_RapChieuPhim;User Id=" + user + ";Password=" + pass + ";";

        public DataTable ExecQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }

        public int ExecNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    data = cmd.ExecuteNonQuery();
                }
            }
            return data;
        }

        public object ExecScalar(string query, Dictionary<string, object> parameters = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentException("Query không được để trống!", "query");
            }

            object data = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        data = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi ra file hoặc hiển thị thông báo
                Console.WriteLine("Lỗi khi thực thi truy vấn: " + ex.Message);
            }

            return data;
        }
    }
}