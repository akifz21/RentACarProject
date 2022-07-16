using Business.Abstract;
using Core.Utilities.Results;
using Entitites.Concrete;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.FileHelper;
using Business.Constants;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, CarImage carImage)
        { 
            var result = BusinessRules.Run(CheckImageLimit(carImage.CarId));
            if (result!=null)
            {
                return result;
            }

            carImage.ImagePath = _fileHelper.Upload(file, PathCostans.ImagesPath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(PathCostans.ImagesPath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int CarId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c=>c.CarId==CarId));
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c=>c.Id==id));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathCostans.ImagesPath + carImage.ImagePath, PathCostans.ImagesPath);
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

       

        private IResult CheckImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId==carId).Count;
            if (result>=5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();

        }
    }
}
