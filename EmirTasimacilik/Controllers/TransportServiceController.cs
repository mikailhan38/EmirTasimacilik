using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EmirTasimacilik.Controllers
{
    public class TransportServiceController : Controller
    {
        private readonly ITransportService _transportService;

        public TransportServiceController(ITransportService transportService)
        {
            _transportService = transportService;
        }

        public IActionResult Index()
        {
            var values = _transportService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult TransportServiceAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TransportServiceAdd(TransportService transportService)
        {
            _transportService.Add(transportService);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult TransportServiceUpdate(int id)
        {
            var values = _transportService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult TransportServiceUpdate(TransportService transportService)
        {
            _transportService.Update(transportService);
            return RedirectToAction("Index");
        }
        public IActionResult TransportServiceDelete(int id)
        {
            var values = _transportService.GetById(id);
            _transportService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
