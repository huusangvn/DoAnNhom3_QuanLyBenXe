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
            string sTruyVan = @"select * from ChuyenXe, BanVe,TuyenXe where ChuyenXe.IdChuyen = BanVe.IdChuyen and ChuyenXe.IdTuyen = TuyenXe.IdTuyen";
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
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach"];

                bv.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();
                bv.Gia1 = (int)dt.Rows[i]["Gia"];
                bv.NgayDi1 = (DateTime)dt.Rows[i]["NgayDi"];
                bv.Gio1 = dt.Rows[i]["Gio"].ToString();
                bv.So_Xe1 = dt.Rows[i]["So_Xe"].ToString();
                lstBanVe.Add(bv);
            }
            conn.Close();
            return lstBanVe;
        }

        //Tìm tuyến xe theo mã
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
                bv.IDVe1 = dt.Rows[i]["IdVe"].ToString();
                bv.TenHanhKhach1 = dt.Rows[i]["TenHanhKhach"].ToString();
                bv.SDTHanhKhach1 = (int)dt.Rows[i]["SDTHanhKhach"];

                bv.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();
                bv.Gia1 = (int)dt.Rows[i]["Gia"];
                bv.NgayDi1 = (DateTime)dt.Rows[i]["NgayDi"];
                bv.Gio1 = dt.Rows[i]["Gio"].ToString();
                bv.So_Xe1 = dt.Rows[i]["So_Xe"].ToString();
                lstBanVe.Add(bv);
            }
            conn.Close();
            return lstBanVe;
        }

        public static bool ThemVeXe(BanVe_DTO bv)
        {
            string sTruyVan = string.Format(@"insert into BanVe values(N'{0}',
N'{1}',N'{2}',N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')", bv.IDVe1, bv.TenHanhKhach1, bv.SDTHanhKhach1, bv.TenTuyen1,bv.NgayDi1,bv.Gio1,bv.So_Xe1, bv.Gia1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }

       /* // SuaTuyenXe
        public static bool SuaTuyenXe(TuyenXe_DTO tx)
        {
            string sTruyVan = string.Format(@"update TuyenXe set IdTuyen=N'{0}',TenTuyen=N'{1}',DiaDiemDi=N'{2}',DiaDiemDen='{3}',Gia=N'{4}' where IdTuyen=N'{0}'", tx.IdTuyen1, tx.TenTuyen1, tx.DiaDiemDi1, tx.DiaDiemDen1, tx.Gia1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;

        }*/
    }
}
