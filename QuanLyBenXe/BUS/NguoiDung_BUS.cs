using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NguoiDung_BUS
    {
        public static List<NguoiDung_DTO> LayNguoiDung()
        {
            return NguoiDung_DAO.LayNguoiDung();
        }
    }
}
