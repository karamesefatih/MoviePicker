using Business.Abstract;
using Business.ResponseMessages;
using Core.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Categories categories)
        {
            _categoryDal.Add(categories);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Categories categories)
        {
            _categoryDal.Delete(categories);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<List<Categories>> GetAll()
        {
            _categoryDal.GetList();
            return new SuccessDataResult<List<Categories>>(_categoryDal.GetList());
        }
    }
}
