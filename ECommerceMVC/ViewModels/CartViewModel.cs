using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMVC.ViewModels
{
    public class CartViewModel
    {
        public int MaHH { get; set; }
        public string Hinh { get; set; }
        public int TenHH { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien => SoLuong * DonGia; // tu tinh ra



    }
}
