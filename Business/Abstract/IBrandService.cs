using Entitites.Concrete;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetBrandById(int id);
        IResult Add (Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);

    }
}
