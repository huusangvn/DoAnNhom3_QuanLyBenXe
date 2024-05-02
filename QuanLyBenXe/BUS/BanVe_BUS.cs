using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class BanVe_BUS
    {
        public static List<BanVe_DTO> LayVe()
        {
            return BanVe_DAO.LayVe();
        }
        //Tìm vé  theo mã
        public static List<BanVe_DTO> TimVeTheoMa(string ma)
        {
            return BanVe_DAO.TimVeTheoMa(ma);
        }
        // Thêm vé xe
        public static bool ThemVeXe(BanVe_DTO bv)
        {
            return BanVe_DAO.ThemVeXe(bv);
        }
    } 
}
