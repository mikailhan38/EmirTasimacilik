using DataAccess.Abstract;
using DataAccess.Repository;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWelcomeDal:GenericRepository<Welcome>,IWelcomeDal
    {
        
    }
}
