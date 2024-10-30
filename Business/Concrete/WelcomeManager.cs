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
    public class WelcomeManager : IWelcomeService
    {
        private readonly IWelcomeDal _welcomeDal;

        public WelcomeManager(IWelcomeDal welcomeDal)
        {
            _welcomeDal = welcomeDal;
        }

        public void Add(Welcome entity)
        {
            _welcomeDal.Add(entity);
        }

        public void Delete(Welcome entity)
        {
            _welcomeDal.Delete(entity);
        }

        public List<Welcome> GetAll()
        {
            return _welcomeDal.GetAll();
        }

        public Welcome GetById(int id)
        {
            return _welcomeDal.GetById(id);
        }

        public void Update(Welcome entity)
        {
            _welcomeDal.Update(entity);
        }
    }
}
