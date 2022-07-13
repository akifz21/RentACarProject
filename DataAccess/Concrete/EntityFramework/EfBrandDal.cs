using Entitites.Concrete;
using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand,RentACarContext>,IBrandDal
    {
    }
}
