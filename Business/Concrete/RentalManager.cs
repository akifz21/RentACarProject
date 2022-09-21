using Business.Abstract;
using Core.Utilities.Results;
using Entitites.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarService _carService;
        public RentalManager(IRentalDal rentalDal,ICarService carService)
        {
            _rentalDal = rentalDal;
            _carService = carService;
        }
        public IResult Add(Rental rental)
        {
            var rules = BusinessRules.Run(CheckIfCarRentable(rental.CarId)).Success;
            if (rules)
            {
                _carService.UpdateIsRentable(rental.CarId,false);
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
        private IResult CheckIfCarRentable(int carId)
        {
            var car = _carService.GetById(carId).Data;
            if (car.IsRentable == true)
            {
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
        }

    }
}
