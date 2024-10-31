using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.ViewComponents
{
    public class _ImageSlider:ViewComponent
    {
        private readonly IImageService _imageService;

        public _ImageSlider(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _imageService.GetAll();
            return View(values);
        }
    }
}
