using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmirTasimacilik.ViewComponents
{
    public class _Contact : ViewComponent
    {
        private readonly IContactService _contactService;

        public _Contact(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new Contact()); // Boş contact modeli ile view'ı render et
        }




    }
}
