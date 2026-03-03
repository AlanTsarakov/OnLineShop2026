using Microsoft.AspNetCore.Mvc;

namespace OnLineShop2026.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
