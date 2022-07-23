using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails(Expression<Func<CarDetailsDto, bool>> filter = null);
        CarDetailsDto GetCarDetail(Expression<Func<CarDetailsDto, bool>> filter);

    }
}
