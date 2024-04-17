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
    } 
}
