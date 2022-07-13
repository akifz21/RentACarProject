using Entitites.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color,RentACarContext>,IColorDal
    {
    }
}
