using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TuyenXe_DTO
    {
        private string IdTuyen;
        private string TenTuyen;
        private string DiaDiemDi;
        private string DiaDiemDen;
        private int Gia;
        public string IdTuyen1 { get => IdTuyen; set => IdTuyen = value; }

        public string TenTuyen1 { get => TenTuyen; set => TenTuyen = value; }
        public string DiaDiemDi1 { get => DiaDiemDi; set => DiaDiemDi = value; }
        public string DiaDiemDen1 { get => DiaDiemDen; set => DiaDiemDen = value; }
        public int Gia1 { get => Gia; set => Gia = value; }
    }
}
