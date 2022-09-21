using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public CarDetailsDto GetCarDetail(Expression<Func<CarDetailsDto, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join p in context.Colors on c.ColorId equals p.ColorId
                             join i in context.CarImages on c.CarId equals i.CarId
                             join u in context.Users on c.OwnerId equals u.UserId
                             select new CarDetailsDto
                             {
                                 CarId = c.CarId,
                                 IsRentable = c.IsRentable,
                                 OwnerId = c.OwnerId,
                                 OwnerName = u.FirstName + " " + u.LastName,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = p.ColorName,
                                 ImagePath = i.ImagePath,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 ColorId = p.ColorId,
                                 BrandId = b.BrandId,

                             };
                return result.SingleOrDefault(filter);
            }
        }

        public List<CarDetailsDto> GetCarDetails(Expression<Func<CarDetailsDto, bool>> filter=null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join p in context.Colors on c.ColorId equals p.ColorId
                             join i in context.CarImages on c.CarId equals i.CarId
                             join u in context.Users on c.OwnerId equals u.UserId
                             select new CarDetailsDto
                             {
                                 CarId = c.CarId,
                                 IsRentable = c.IsRentable,
                                 OwnerId = c.OwnerId,
                                 OwnerName = u.FirstName +" "+u.LastName,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = p.ColorName,
                                 ImagePath = i.ImagePath,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 ColorId = p.ColorId,
                                 BrandId = b.BrandId,

                             };
                return filter == null ? result.ToList():result.Where(filter).ToList();
            }
        }

        public void UpdateIsRentable(int carId, bool isRentable)
        {
            var car = new Car { CarId = carId, IsRentable = isRentable };
            using (RentACarContext context = new RentACarContext())
            {
                context.Cars.Attach(car);
                context.Entry(car).Property(c => c.IsRentable).IsModified = true;
                context.SaveChanges();
            }
        }
    }
}
