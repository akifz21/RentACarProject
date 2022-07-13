using Business.Abstract;
using Entitites.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            return new SuccessResult();
            _brandDal.Add(brand);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult();
            _brandDal.Delete(brand);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.BrandId==id));
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult();
            _brandDal.Update(brand);
        }
    }
}
