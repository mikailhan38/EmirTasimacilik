using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.ViewComponents
{
    public class _SocialMedia:ViewComponent
    {
        private readonly ISocialService _socialService;

        public _SocialMedia(ISocialService socialService)
        {
            _socialService = socialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialService.GetAll();
            return View(values);
        }

    }
}
