using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join p in context.Colors on c.ColorId equals p.ColorId
                             select new CarDetailsDto
                             {
                                 CarId = c.CarId,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = p.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();                             
            }
        }

    }
}
