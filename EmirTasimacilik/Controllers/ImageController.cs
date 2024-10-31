using Business.Abstract;
using Business.Concrete;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace EmirTasimacilik.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImageController(IImageService imageService, IWebHostEnvironment webHostEnvironment)
        {
            _imageService = imageService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _imageService.GetAll();
            return View(values);
        }
        [HttpGet]
        public  IActionResult ImageUpload()
        {
            
            return View();
        }


        [HttpPost]
        public async  Task<IActionResult> ImageUpload(IFormFile file, Image image)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Resim yüklenemedi.");
            }

            // Benzersiz dosya adı oluştur
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName);

            // Resmi sunucuda wwwroot/images dizinine kaydet
            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            image.ImageUrl = "/images/" + fileName;
            _imageService.Add(image);
            return View();
        }
        public IActionResult ImageDelete(int id)
        {
            var values = _imageService.GetById(id);
            _imageService.Delete(values);
            return RedirectToAction("Index");
        }

    }
}
