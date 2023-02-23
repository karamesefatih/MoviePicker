using Core.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Categories categories);
        IResult Delete(Categories categories);
        IDataResult<List<Categories>> GetAll();
    }
}
