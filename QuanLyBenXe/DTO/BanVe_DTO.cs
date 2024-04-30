using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BanVe_DTO
    {
        private string IDVe;
        private string TenHanhKhach;
        private int SDTHanhKhach;

        public string IDVe1 { get => IDVe; set => IDVe = value; }
        public string TenHanhKhach1 { get => TenHanhKhach; set => TenHanhKhach = value; }
        public int SDTHanhKhach1 { get => SDTHanhKhach; set => SDTHanhKhach = value; }
        public string TenTuyen1 { get => TenTuyen; set => TenTuyen = value; }
        public DateTime? NgayDi1 { get => NgayDi; set => NgayDi = value; }
        public string Gio1 { get => Gio; set => Gio = value; }
        public string So_Xe1 { get => So_Xe; set => So_Xe = value; }

        private string TenTuyen;
        private DateTime? NgayDi;
        private string Gio;
        private string So_Xe;

    }
}
