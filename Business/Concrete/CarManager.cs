using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules;
using Business.BusinessAspect.Autofac;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            car.IsRentable = true;
            _carDal.Add(car);
            return new SuccessResult(car.CarId.ToString());
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.CarId==id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
        }

       
        public IDataResult<CarDetailsDto> GetCarDetailById(int id)
        {
            return new SuccessDataResult<CarDetailsDto>(_carDal.GetCarDetail(d=>d.CarId==id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId==BrandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId==ColorId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
           
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetailsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(d => d.BrandId == brandId));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetailsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(d=>d.ColorId==colorId));
        }

        public IResult UpdateIsRentable(int carId, bool isRentable)
        {
            _carDal.UpdateIsRentable(carId, isRentable);
            return new SuccessResult();
        }
        public IDataResult<List<CarDetailsDto>> GetCarDetailsByUserId(int userId)
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(c => c.OwnerId == userId));
        }
    }
}
