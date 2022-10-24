using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailsDTO> GetRentalDetails(Expression<Func<RentalDetailsDTO, bool>> filter=null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join u in context.Users on r.UserId equals u.UserId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new RentalDetailsDTO
                             {
                                 UserName = u.FirstName + u.LastName,
                                 UserId = u.UserId,
                                 BrandName = b.BrandName,
                                 CarId = c.CarId,
                                 IsRentable = c.IsRentable,
                                 RentalId = r.RentalId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                                
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
