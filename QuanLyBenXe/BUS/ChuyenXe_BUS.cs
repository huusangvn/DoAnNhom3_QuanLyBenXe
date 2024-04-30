using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class ChuyenXe_BUS
    {
        public static List<ChuyenXe_DTO> LayChuyenXe()
        {
            return ChuyenXe_DAO.LayChuyenXe();
        }
    }
}
