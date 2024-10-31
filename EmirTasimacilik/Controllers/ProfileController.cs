using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class ProfileController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
