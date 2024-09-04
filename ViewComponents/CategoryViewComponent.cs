using ECommerceMVC.Data;
using ECommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMVC.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        // ket noi co so du lieu
        private readonly hshop2023Context db;
        public CategoryViewComponent(hshop2023Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loai.Select(lo => new CategoryViewModel
            {
                MaLoai = lo.MaLoai, TenLoai = lo.TenLoai, SoLuong = lo.HangHoa.Count()
            }).OrderBy(p => p.SoLuong);
            return View(data); //Default.cshtml
            //return View("Default", data); 
        }
    }
}
