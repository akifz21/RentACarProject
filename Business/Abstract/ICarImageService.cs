using Core.Utilities.Results;
using Entitites.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file,CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file,CarImage carImage);

        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAllByCarId(int CarId);

    }
}
