using Microsoft.AspNetCore.Mvc;

namespace SalaChat.Controllers
{
    public class ChatsController : Controller
    {
        public IActionResult Chat(int idChat)
        {
            return View("Chat", idChat);
        }
    }
}
