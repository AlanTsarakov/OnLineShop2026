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
            User user = new User("Алан", "Цараков", "alantsarakov@vk.com", "https://avatars.mds.yandex.net/i?id=7acb83785e60f3df8da676c2b2227b5d_l-5237670-images-thumbs&n=13");
            return View(user);
        }
    }
}
