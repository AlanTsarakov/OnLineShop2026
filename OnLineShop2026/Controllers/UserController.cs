using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        //IProductRepository productsRepository;

        //public UserController(IProductRepository prodRep)
        //{
        //    this.productsRepository = prodRep;
        //}
        public IActionResult Index()
        {
            User user = new User("Алан", "Цараков", "alantsarakov@vk.com", null);
            return View(User);
        }
    }
}
