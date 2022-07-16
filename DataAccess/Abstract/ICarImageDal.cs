using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entitites.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarImageDal:IEntityRepository<CarImage>
    {
    }
}
