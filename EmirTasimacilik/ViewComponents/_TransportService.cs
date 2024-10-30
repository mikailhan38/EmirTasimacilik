using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.ViewComponents
{
    public class _TransportService:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
