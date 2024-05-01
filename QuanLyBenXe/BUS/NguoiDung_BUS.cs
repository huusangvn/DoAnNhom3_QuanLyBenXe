using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Security.Cryptography;

namespace BUS
{
    public class NguoiDung_BUS
    {
        public static List<NguoiDung_DTO> LayNguoiDung()
        {
            return NguoiDung_DAO.LayNguoiDung();
        }

        internal static string GetMd5Hash(MD5 md5Hash, string matkhau)
        {
            throw new NotImplementedException();
        }
    }
}
