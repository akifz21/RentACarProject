using Entitites.Concrete;
using Core.Utilities.Results;
using Entitites.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetByUserId(int userId);
        IDataResult<List<RentalDetailsDTO>> GetRentalDetailsByUserId(int userId);
    }
}
