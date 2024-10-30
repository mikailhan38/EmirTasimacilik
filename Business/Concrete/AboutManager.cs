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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void Add(About entity)
        {
            _aboutdal.Add(entity);
        }

        public void Delete(About entity)
        {
           _aboutdal.Delete(entity);
        }

        public List<About> GetAll()
        {
            return _aboutdal.GetAll();
        }

        public About GetById(int id)
        {
            return _aboutdal.GetById(id);
        }

        public void Update(About entity)
        {
            _aboutdal.Update(entity);
        }
    }
}
