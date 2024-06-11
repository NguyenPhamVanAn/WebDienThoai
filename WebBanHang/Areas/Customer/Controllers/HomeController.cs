using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;        
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;           
        }
        //hien thi danh sach tat ca san pham       
        public IActionResult Index()
        {
            var productlist = _db.Products.ToList();
            return View(productlist);
        }

        public IActionResult AddToCart(int productId) {

            var product = _db.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                var cart = HttpContext.Session.GetJson<Cart>("cart");
                if (cart == null)
                    cart = new Cart();

                cart.Add(product, 1);
                HttpContext.Session.SetJson("cart", cart);
                return Json(new { success = "Ok", qty = cart.Items.Count });
            }else
                return Json(new { error = "Ok" }); 
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
