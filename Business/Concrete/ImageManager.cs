using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void Add(Image entity)
        {
            _imageDal.Add(entity);
        }

        public void Delete(Image entity)
        {
            _imageDal.Delete(entity);
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }

        public Image GetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public void Update(Image entity)
        {
            _imageDal.Update(entity);
        }
    }
}
