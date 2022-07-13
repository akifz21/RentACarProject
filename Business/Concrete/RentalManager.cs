using Business.Abstract;
using Core.Utilities.Results;
using Entitites.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var checkIfCarRented = rental.ReturnDate;
            if (checkIfCarRented != null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Car Succesfully Rented");
            }
            else
            {
                return new ErrorResult();
            }
            
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.RentalId==id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
