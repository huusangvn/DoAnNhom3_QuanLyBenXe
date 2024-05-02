﻿using System;
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
        public static List<BanVe_DTO> BanVe()
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
                bv.IdVe1 = dt.Rows[i]["IdVe"].ToString();
                bv.IdChuyen1 = dt.Rows[i]["IdChuyen"].ToString();
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach"];
                lstBanVe.Add(bv);
            }
            conn.Close();
            return lstBanVe;
        }

        //Tìm vé xe theo mã
        public static List<BanVe_DTO> TimVeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from BanVe where IdVe like '%{0}%'", ma);
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
                bv.IdVe1 = dt.Rows[i]["IdVe"].ToString();
                bv.IdChuyen1 = dt.Rows[i]["IdChuyen"].ToString();
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach"];
                lstBanVe.Add(bv);
            }
            conn.Close();
            return lstBanVe;
        }

        //Thêm vé
        public static bool ThemVe(BanVe_DTO bv)
        {
            string sTruyVan = string.Format(@"insert into BanVe values(N'{0}',
N'{1}',N'{2}',N'{3}')", bv.IdVe1,bv.IdChuyen1,bv.TenHanhKhach1,bv.SDTHanhKhach1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
    }
}
