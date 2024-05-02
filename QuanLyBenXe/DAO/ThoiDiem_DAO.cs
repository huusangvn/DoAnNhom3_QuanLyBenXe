using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
   public class ThoiDiem_DAO
    {
        static SqlConnection conn;
        public static List<ThoiDiem_DTO> LayThoiDiem()
        {
            string sTruyVan = @"select *from ThoiDiem";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThoiDiem_DTO> lstThoiDiem = new List<ThoiDiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThoiDiem_DTO td = new ThoiDiem_DTO();
                td.IdThoiDiem1 = dt.Rows[i]["IdThoiDiem"].ToString();
                td.Ngay1 = (DateTime)dt.Rows[i]["Ngay"];
                td.Gio1 = dt.Rows[i]["Gio1"].ToString();

                lstThoiDiem.Add(td);
            }
            conn.Close();
            return lstThoiDiem;
        }
    }
}
