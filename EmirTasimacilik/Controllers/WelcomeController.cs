using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly IWelcomeService _welcomeService;

        public WelcomeController(IWelcomeService welcomeService)
        {
           _welcomeService = welcomeService;
        }

        public IActionResult Index()
        {
            var values = _welcomeService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult WelcomeAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WelcomeAdd(Welcome welcome)
        {

            _welcomeService.Add(welcome);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult WelcomeUpdate(int id)
        {
            var values =_welcomeService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult WelcomeUpdate(Welcome welcome)
        {

            _welcomeService.Update(welcome);

            return RedirectToAction("Index");

        }
    }
}
