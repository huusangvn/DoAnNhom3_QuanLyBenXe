﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class ThoiDiem_BUS
    {
        public static  List<ThoiDiem_DTO> LayThoiDiem()
        {
            return ThoiDiem_DAO.LayThoiDiem();
        }

    }
}
