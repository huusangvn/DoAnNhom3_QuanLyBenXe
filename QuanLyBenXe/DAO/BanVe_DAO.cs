using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class BanVe_DAO
    {

        static SqlConnection conn;
        public static List<BanVe_DTO> LayVe()
        {
            string sTruyVan = @"select *from BanVe";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BanVe_DTO> lstBanVe = new List<BanVe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanVe_DTO bv = new BanVe_DTO();
                bv.IDVe1 = dt.Rows[i]["IdVe"].ToString();
                bv.IdChuyen1 = dt.Rows[i]["IdChuyen"].ToString();
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach1"];
                lstBanVe.Add(bv);
            }
            conn.Close();
            return lstBanVe;
        }
    }
}
