using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietBanVe_BUS
    {
        public static List<ChiTietBanVe_DTO> LayVe()
        {
            return ChiTietBanVe_DAO.LayVe();
        }

        //Tìm vé  theo mã
        public static List<ChiTietBanVe_DTO> TimVeTheoMa(string ma)
        {
            return ChiTietBanVe_DAO.TimVeTheoMa(ma);
        }
    } 
}
