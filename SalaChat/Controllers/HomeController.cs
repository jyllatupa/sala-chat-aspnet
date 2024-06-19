using Microsoft.AspNetCore.Mvc;

namespace SalaChat.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public static Dictionary<int, string> ListaChats = new Dictionary<int, string>()
        {
            {1, "FAMILIA" },
            {2, "AMIGOS" },
            {3, "TRABAJO" },
        };

        public IActionResult Index()
        {
            return View(ListaChats);
        }
    }
}
