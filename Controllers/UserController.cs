using Microsoft.AspNetCore.Mvc;

namespace JuneMyApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View();
        }


        public IActionResult Delete()
        {
            return View();
        }

    }
}
