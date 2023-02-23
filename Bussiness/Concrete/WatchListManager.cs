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
    public class WatchListManager : IWatchListService
    {
        private readonly IWatchListDal _watchListDal;

        public WatchListManager(IWatchListDal watchListDal)
        {
            _watchListDal = watchListDal;
        }

        public IResult Add(WatchList list)
        {
            _watchListDal.Add(list);
            return new SuccessResult(Messages.WatchListAdded);
            
        }

        public IResult Delete(WatchList list)
        {
            _watchListDal.Delete(list);
            return new SuccessResult(Messages.WatchListDeleted);

        }

        public IDataResult<List<WatchList>> GetAll()
        {
            return new SuccessDataResult<List<WatchList>>(_watchListDal.GetList());
        }
    }
}
