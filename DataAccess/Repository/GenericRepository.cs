using DataAccess.Abstract;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppContext = DataAccess.Context.WebAppContext;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using WebAppContext _appContext = new WebAppContext();
            _appContext.Add(entity);
            _appContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            using WebAppContext _appContext = new WebAppContext();
            _appContext.Remove(entity);
            _appContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            using WebAppContext _appContext = new WebAppContext();
            return _appContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using WebAppContext _appContext = new WebAppContext();
            return _appContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using WebAppContext _appContext = new WebAppContext();
            _appContext.Update(entity);
            _appContext.SaveChanges();
        }
    }
}
