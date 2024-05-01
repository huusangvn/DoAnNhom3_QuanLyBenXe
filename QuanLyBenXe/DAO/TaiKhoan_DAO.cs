using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection conn;
        // Lấy thông tin người dùng có tên đăng nhập và mật khẩu tương ứng, trả về null nếu không thấy
        public static TaiKhoan_DTO LayTaiKhoan(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from NguoiDung where IdNguoiDung=N'{0}' and PassND='{1}'", ten, matkhau);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();

            tk.IdNguoiDung1 = dt.Rows[0]["IdNguoiDung"].ToString();
            tk.PassND1 = dt.Rows[0]["PassND"].ToString();
            tk.IdLoaiND1 = (int)dt.Rows[0]["IdLoaiND"];

            conn.Close();
            return tk;

        }
        public static bool CapNhatTaiKhoan(NguoiDung_DTO nd)
        {
            string sql = string.Format(@"update NguoiDung set PassND='{0}' where IdNguoiDung='{1}'", nd.PassND1, nd.IdNguoiDung1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }

    }
}
