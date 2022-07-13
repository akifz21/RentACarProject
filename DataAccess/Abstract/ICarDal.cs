using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;


namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails();
        
    }
}
