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
    public class TransportServiceManager : ITransportService
    {
        private readonly ITransportServiceDal _transportServiceDal;

        public TransportServiceManager(ITransportServiceDal transportServiceDal)
        {
            _transportServiceDal = transportServiceDal;
        }

        public void Add(TransportService entity)
        {
            _transportServiceDal.Add(entity);
        }

        public void Delete(TransportService entity)
        {
            _transportServiceDal.Delete(entity);
        }

        public List<TransportService> GetAll()
        {
            return _transportServiceDal.GetAll();
        }

        public TransportService GetById(int id)
        {
            return _transportServiceDal.GetById(id);
        }

        public void Update(TransportService entity)
        {
            _transportServiceDal.Update(entity);
        }
    }
}
