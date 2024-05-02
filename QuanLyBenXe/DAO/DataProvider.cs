using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection Connect()
        {
            string sTruyVan = @"Data Source=ADMIN\MSSQLSEVER;Initial Catalog=QuanLyBenXe;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sTruyVan);
            conn.Open();
            return conn;
        }

        //Truy van lay du lieu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection Connect)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Truy vấn không lấy dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection Connect)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, Connect);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}   
