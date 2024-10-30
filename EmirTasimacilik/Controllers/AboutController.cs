using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values =_aboutService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AboutAdd(About About)
        {

            _aboutService.Add(About);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = _aboutService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About About)
        {
            _aboutService.Update(About);
            return RedirectToAction("Index");
        }
    }
}
