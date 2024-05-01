using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
   public class NguoiDung_DAO
    {
        static SqlConnection conn;
        public static List<NguoiDung_DTO> LayNguoiDung()
        {
            string sTruyVan = @"select * from NguoiDung";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> lstNguoiDung = new List<NguoiDung_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.IdNguoiDung1 = dt.Rows[i]["IdNguoiDung"].ToString();
                nd.PassND1 = dt.Rows[i]["PassND"].ToString();
                nd.HoTen1 = dt.Rows[i]["HoTen"].ToString();
                nd.NgaySinh1 = (DateTime)dt.Rows[i]["NgaySinh"];
                nd.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                nd.DiaChi1 = dt.Rows[i]["DiaChi"].ToString();
                nd.SoDT1 = dt.Rows[i]["SoDT"].ToString();
                nd.IdLoaiND1 = dt.Rows[i]["IdLoaiND"].ToString();
                lstNguoiDung.Add(nd);
            }
            conn.Close();
            return lstNguoiDung;
        }
    }
}
