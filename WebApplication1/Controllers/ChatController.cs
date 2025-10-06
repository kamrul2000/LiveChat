using Microsoft.AspNetCore.Mvc;

namespace LiveChatApp.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
