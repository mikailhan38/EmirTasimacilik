using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.ViewComponents
{
    public class _Welcome :ViewComponent
    {
        IWelcomeService _welcomeService;

        public _Welcome(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _welcomeService.GetAll();
            return View(values);
        }

    }
}
