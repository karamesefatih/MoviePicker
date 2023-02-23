using Core.Concrete;
using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;

namespace DataAccess.Concrete.EfDals
{
    public class EfCategoryDal : GenericRepository<Categories, MoviePickerContext>, ICategoryDal
    {
    }
}
