using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
using System.Data;


namespace DAO
{
    public class TuyenXe_DAO
    {
        static SqlConnection conn;
        public static List<TuyenXe_DTO> LayTuyenXe()
        {
            string sTruyVan = @"select *from TuyenXe";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TuyenXe_DTO> lstTuyenXe = new List<TuyenXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TuyenXe_DTO tx = new TuyenXe_DTO();
                tx.IdTuyen1 = dt.Rows[i]["IdTuyen"].ToString();
                tx.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();
                tx.DiaDiemDi1 = dt.Rows[i]["DiaDiemDi"].ToString();
                tx.DiaDiemDen1 = dt.Rows[i]["DiaDiemDen"].ToString();
                tx.Gia1 = (int)dt.Rows[i]["Gia"];
                lstTuyenXe.Add(tx);
            }
            conn.Close();
            return lstTuyenXe;
        }

        //Tìm tuyến xe theo mã
        public static List<TuyenXe_DTO> TimTuyenXeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from TuyenXe where IdTuyen like '%{0}%' or TenTuyen = '%{0}%'", ma);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TuyenXe_DTO> lstTuyenXe = new List<TuyenXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TuyenXe_DTO tx = new TuyenXe_DTO();
                tx.IdTuyen1 = dt.Rows[i]["IdTuyen"].ToString();
                tx.TenTuyen1 = dt.Rows[i]["TenTuyen"].ToString();
                tx.DiaDiemDi1 = dt.Rows[i]["DiaDiemDi"].ToString();
                tx.DiaDiemDen1 = dt.Rows[i]["DiaDiemDen"].ToString();
                tx.Gia1 = (int)dt.Rows[i]["Gia"];
                lstTuyenXe.Add(tx);
            }
            conn.Close();
            return lstTuyenXe;
        }

        //Thêm tuyến
        public static bool ThemTuyenXe(TuyenXe_DTO tx)
        {
            string sTruyVan = string.Format(@"insert into TuyenXe values(N'{0}',
N'{1}',N'{2}',N'{3}', N'{4}')", tx.IdTuyen1, tx.TenTuyen1, tx.DiaDiemDi1, tx.DiaDiemDen1,tx.Gia1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }

        // SuaTuyenXe
        public static bool SuaTuyenXe(TuyenXe_DTO tx)
        {
            string sTruyVan = string.Format(@"update TuyenXe set IdTuyen=N'{0}',TenTuyen=N'{1}',DiaDiemDi=N'{2}',DiaDiemDen='{3}',Gia=N'{4}' where IdTuyen=N'{0}'", tx.IdTuyen1, tx.TenTuyen1, tx.DiaDiemDi1, tx.DiaDiemDen1, tx.Gia1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;

        }

        // XoaTuyenXe
        public static bool XoaTuyenXe(TuyenXe_DTO tx)
        {
            string sTruyVan = string.Format(@"delete from TuyenXe where IdTuyen=N'{0}'", tx.IdTuyen1);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
    }
}
