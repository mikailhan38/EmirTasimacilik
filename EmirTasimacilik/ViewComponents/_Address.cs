using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.ViewComponents
{
    public class _Address:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _Address(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.GetAll();
            return View(values);
        }
    }
}
