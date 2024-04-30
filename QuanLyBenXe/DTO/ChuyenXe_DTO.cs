using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChuyenXe_DTO
    {
        private string IdChuyen;
        private string IdTuyen;
        private DateTime NgayDi;
        private string Gio;
        private string So_Xe;

        public string IdChuyen1 { get => IdChuyen; set => IdChuyen = value; }
        public string IdTuyen1 { get => IdTuyen; set => IdTuyen = value; }
        public DateTime NgayDi1 { get => NgayDi; set => NgayDi = value; }
        public string Gio1 { get => Gio; set => Gio = value; }
        public string So_Xe1 { get => So_Xe; set => So_Xe = value; }
        public string TenTuyen1 { get => TenTuyen; set => TenTuyen = value; }

        private string TenTuyen;
    }
}
