using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
    }
}
