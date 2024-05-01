using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
   public class Xe_BUS
    {
        public static List<Xe_DTO> LayXe()
        {
            return Xe_DAO.LayXe();
        }
    }
}
