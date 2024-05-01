using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NguoiDung_DTO
    {
        private string IdNguoiDung;
        private string PassND;
        private string HoTen;
        private DateTime? NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SoDT;
        private string IdLoaiND;

        public string IdNguoiDung1 { get => IdNguoiDung; set => IdNguoiDung = value; }
        public string PassND1 { get => PassND; set => PassND = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime? NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public string IdLoaiND1 { get => IdLoaiND; set => IdLoaiND = value; }
    }
}
