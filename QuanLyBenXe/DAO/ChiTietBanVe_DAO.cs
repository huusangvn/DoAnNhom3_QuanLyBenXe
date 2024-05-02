using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class ChiTietBanVe_DAO
    {

        static SqlConnection conn;
        public static List<ChiTietBanVe_DTO> LayVe()
        {
            string sTruyVan = @"select bv.*, cx.NgayDi, cx.Gio, cx.So_Xe,cx.IdTuyen, tx.TenTuyen from TuyenXe tx, ChuyenXe cx, BanVe bv where cx.IdChuyen = bv.IdChuyen and cx.IdTuyen = tx.IdTuyen";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietBanVe_DTO> lstBanVe = new List<ChiTietBanVe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietBanVe_DTO bv = new ChiTietBanVe_DTO();
                bv.IDVe1 = dt.Rows[i]["IdVe"].ToString();
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach"];
                bv.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();
                bv.NgayDi1 = (DateTime)dt.Rows[i]["NgayDi"];
                bv.Gio1 = dt.Rows[i]["Gio"].ToString();
                bv.So_Xe1 = dt.Rows[i]["So_Xe"].ToString();
                lstBanVe.Add(bv);
            }
            conn.Close();
            return lstBanVe;
        }

        //Tìm tuyến xe theo mã
        public static List<ChiTietBanVe_DTO> TimVeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from BanVe where IdVe like '%{0}%'", ma);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietBanVe_DTO> lstBanVe = new List<ChiTietBanVe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietBanVe_DTO bv = new ChiTietBanVe_DTO();
                bv.IDVe1 = dt.Rows[i]["IdVe"].ToString();
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach"];
/*
                bv.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();
                bv.Gia1 = (int)dt.Rows[i]["Gia"];
                bv.NgayDi1 = (DateTime)dt.Rows[i]["NgayDi"];
                bv.Gio1 = dt.Rows[i]["Gio"].ToString();
                bv.So_Xe1 = dt.Rows[i]["So_Xe"].ToString();
                lstBanVe.Add(bv);*/
            }
            conn.Close();
            return lstBanVe;
        }

    }
}
