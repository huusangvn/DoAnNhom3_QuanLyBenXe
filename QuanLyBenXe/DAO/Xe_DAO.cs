using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class Xe_DAO
    {
        static SqlConnection conn;
        public static List<Xe_DTO> LayXe()
        {
            string sTruyVan = @"select *from Xe";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Xe_DTO> lstXe = new List<Xe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Xe_DTO xe = new Xe_DTO();
                xe.So_Xe1 = dt.Rows[i]["So_Xe"].ToString();
                xe.HieuXe1 = dt.Rows[i]["Hieu_Xe"].ToString();
                xe.DoiXe1 = dt.Rows[i]["Doi_Xe"].ToString();
                xe.So_Cho_Ngoi1 = dt.Rows[i]["So_Cho_Ngoi"].ToString();
                lstXe.Add(xe);
            }
            conn.Close();
            return lstXe;
        }
    }
}
