using Microsoft.AspNetCore.Mvc;

namespace JuneMyApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
