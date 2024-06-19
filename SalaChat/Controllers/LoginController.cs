using Microsoft.AspNetCore.Mvc;

namespace SalaChat.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
