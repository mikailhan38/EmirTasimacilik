using System.Diagnostics;
using EmirTasimacilik.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        

        
    }
}
