using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
