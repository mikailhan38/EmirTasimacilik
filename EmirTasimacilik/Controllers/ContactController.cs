using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetAll();
            return View(values);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitContact([FromForm] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                // Hata durumunda ViewComponent'i hata mesajlarıyla tekrar render et
                return ViewComponent("_Contact", new { model = contact });
            }

            try
            {
                _contactService.Add(contact);
                TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi.";
                return RedirectToAction("Index", "Home"); // veya başka bir sayfaya yönlendir
            }
            catch (Exception ex)
            {
                // Hata loglama yapılabilir
                ModelState.AddModelError("", "Mesajınız gönderilirken bir hata oluştu.");
                return ViewComponent("_Contact", new { model = contact });
            }
        }
        public IActionResult ContactDelete(int id)
        {
            var values = _contactService.GetById(id);
            _contactService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
