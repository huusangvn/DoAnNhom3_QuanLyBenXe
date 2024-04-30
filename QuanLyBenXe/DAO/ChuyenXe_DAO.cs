using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class ChuyenXe_DAO
    {
        static SqlConnection conn;
        public static List<ChuyenXe_DTO> LayChuyenXe()
        {
            
            string sTruyVan = @"select cx.*, tx.* from ChuyenXe cx,TuyenXe tx where cx.IdTuyen = tx.IdTuyen";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan,conn);
            if(dt.Rows.Count== 0)
            {
                return null;
            }
            List<ChuyenXe_DTO> lstChuyenXe = new List<ChuyenXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChuyenXe_DTO cx = new ChuyenXe_DTO();
                cx.IdChuyen1 = dt.Rows[i]["IdChuyen"].ToString();
                cx.NgayDi1 = (DateTime)dt.Rows[i]["NgayDi"];
                cx.Gio1 =dt.Rows[i]["Gio"].ToString();
                cx.So_Xe1 = dt.Rows[i]["So_Xe"].ToString();

     
                cx.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();

                lstChuyenXe.Add(cx);
            }
            conn.Close();
            return lstChuyenXe;
        }
    }
}
