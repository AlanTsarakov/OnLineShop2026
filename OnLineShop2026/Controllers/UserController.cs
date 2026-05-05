using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        IUserRepository usersRepository;

        public UserController(IUserRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public IActionResult Index()
        {
            List<User> users = usersRepository.GetAll();
            return View(users);
        }

        public IActionResult Detail(Guid id)
        {
            User user = usersRepository.TryGetById(id);
            return View(user);
        }
    }
}
