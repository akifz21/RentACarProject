using Core.DataAccess.EntityFramework;
using Entitites.Concrete;
using DataAccess.Abstract;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,RentACarContext>,ICustomerDal
    {
    }
}
