using Core.Concrete;
using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IGenericRepository<Categories>
    {
    }
}
