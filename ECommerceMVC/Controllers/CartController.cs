using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceMVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //them vao gio hang bang id va so luong
        public IActionResult AddToCart(int id, int quantity = 1)
        {
            return View();
        }
    }
}