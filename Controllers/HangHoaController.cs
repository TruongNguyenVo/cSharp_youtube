using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;

using ECommerceMVC.ViewModels;

namespace ECommerceMVC.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly hshop2023Context db;
        public HangHoaController(hshop2023Context context) => db = context;
        public IActionResult Index(int? category)
        {
            //lay tat ca danh sach hang hoa
            var hangHoas = db.HangHoa.AsQueryable();

            //neu co truyen them loai
            if (category.HasValue)
            {
                //lay danh sach dua tren ma loai
                hangHoas = db.HangHoa.Where(p => p.MaLoai == category.Value);
            }

            var result = hangHoas.Select(p => new HangHoaViewModel
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                Gia = p.DonGia ?? 0, // co the bang 0
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai // nhay qua bang loai lay ten loai                
            });

            return View(result);
        }
        public IActionResult Search(string query)
        {
            //lay tat ca danh sach hang hoa
            var hangHoas = db.HangHoa.AsQueryable();
            if (query != null)
            {
                //lay danh sach san pham dua tren ten query
                hangHoas = db.HangHoa.Where(p => p.TenHh.Contains(query));
            }

            var result = hangHoas.Select(p => new HangHoaViewModel
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                Gia = p.DonGia ?? 0, // co the bang 0
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai // nhay qua bang loai lay ten loai                
            });

            return View(result);
        }
    }
}