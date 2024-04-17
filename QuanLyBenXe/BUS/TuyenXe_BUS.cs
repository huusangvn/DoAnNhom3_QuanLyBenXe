using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class TuyenXe_BUS
    {
        public static List<TuyenXe_DTO> LayTuyenXe()
        {
            return TuyenXe_DAO.LayTuyenXe();
        }
        //Tìm tuyen  theo mã
        public static List<TuyenXe_DTO> TimTuyenXeTheoMa(string ma)
        {
            return TuyenXe_DAO.TimTuyenXeTheoMa(ma);
        }
        // Thêm tuyến xe
        public static bool ThemTuyenXe(TuyenXe_DTO nv)
        {
            return TuyenXe_DAO.ThemTuyenXe(nv);
        }
    }
}
