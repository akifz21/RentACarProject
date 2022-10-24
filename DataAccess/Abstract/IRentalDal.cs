using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        List<RentalDetailsDTO> GetRentalDetails(Expression<Func<RentalDetailsDTO, bool>> filter = null);
    }
}
