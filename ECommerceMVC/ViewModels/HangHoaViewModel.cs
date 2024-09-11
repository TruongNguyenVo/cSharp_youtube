using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMVC.ViewModels
{
    public class HangHoaViewModel
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string MoTaNgan { get; set; }
        public string TenLoai { get; set; }
    }
    public class ChiTietHangHoaViewModel
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string MoTaNgan { get; set; }
        public string TenLoai { get; set; }
        public string ChiTiet { get; set;}
        public int DiemDanhGia { get; set; }
        public int SoLuongTon { get; set; }
    }
}
