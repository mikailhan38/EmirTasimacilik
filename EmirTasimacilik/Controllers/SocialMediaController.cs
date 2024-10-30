using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialService _socialService;

        public SocialMediaController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        public IActionResult Index()
        {
            var values= _socialService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult SocialMediaAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SocialMediaAdd(SocialMedia socialMedia)
        {
            _socialService.Add(socialMedia);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult SocialMediaUpdate(int id)
        {
            var values = _socialService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult SocialMediaUpdate(SocialMedia socialMedia)
        {
            _socialService.Update(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult SocialMediaDelete(int id)
        {
            var values = _socialService.GetById(id);
            _socialService.Delete(values);
            return RedirectToAction("Index");
        }

    }
}
