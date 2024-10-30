using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
